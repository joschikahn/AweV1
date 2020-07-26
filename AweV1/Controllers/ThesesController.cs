

using AweV1.Data;
using AweV1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.SqlServer.Query.ExpressionTranslators.Internal;

namespace AweV1.Controllers
{
    public class ThesisController : Controller, IValidatableObject
    {
        public enum SortCriteria
        {
            [Display(Name = "Titel")]
            Title,
            [Display(Name = "Status")]
            Status,
            [Display(Name = "Student")]
            StudentLastName,
            [Display(Name = "Anmeldung")]
            Registration,
            [Display(Name = "Abgabe")]
            Filing,
            [Display(Name = "Typ")]
            Type,
            [Display(Name = "Betreuer")]
            Supervisor
        }

        public enum SortCriteriaPublic
        {
            [Display(Name = "Titel")]
            Title,
            [Display(Name = "Status")]
            Status,
            [Display(Name = "Typ")]
            Type,
            [Display(Name = "Betreuer")]
            Supervisor
        }

        public enum FilterEnum
        {
            [Display(Name = "Frei")]
            Free = 0,

            [Display(Name = "Vorgemerkt")]
            Reserved = 1,

            [Display(Name = "Angemeldet")]
            Registered = 2,

            [Display(Name = "Abgegeben")]
            Filed = 3,

            [Display(Name = "Bewertet")]
            Graded = 4,
        }

        private readonly AppDbContext _context;

        public ThesisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Thesis
        public async Task<IActionResult> Index(string Search, Status Filter, /*Type FilterPublic,*/ SortCriteria Sort = SortCriteria.StudentLastName,
            int Page = 1, int PageSize = 10)
        {
            IQueryable<Thesis> query = _context.thesis;
            query = (Search != null) ? query.Where(m => (m.Title.Contains(Search))) : query;

            query = (!Filter.Equals(null)) ? query.Where(m => m.Status == Filter) : query;
            query = (Filter.Equals(null)) ? _context.thesis : query;

            //query = (!FilterPublic.Equals(null)) ? query.Where(m => m.Type == FilterPublic) : query;

            switch (Sort)
            {
                case SortCriteria.Title:
                    query = query.OrderBy(m => m.Title);
                    break;
                case SortCriteria.Status:
                    query = query.OrderBy(m => m.Status);
                    break;
                case SortCriteria.Supervisor:
                    query = query.OrderBy(m => m.Supervisor);
                    break;
                case SortCriteria.Registration:
                    query = query.OrderBy(m => m.Registration);
                    break;
                case SortCriteria.Filing:
                    query = query.OrderBy(m => m.Filing);
                    break;
                case SortCriteria.Type:
                    query = query.OrderBy(m => m.Type);
                    break;
                default:
                    query = query.OrderBy(m => m.StudentID);
                    break;
            }

            int PageTotal = ((await query.CountAsync()) + PageSize - 1) / PageSize;
            Page = (Page > PageTotal) ? PageTotal : Page;
            Page = (Page < 1) ? 1 : Page;

            ViewBag.Search = Search;
            ViewBag.Filter = Filter;
            //ViewBag.FilterPublic = FilterPublic;
            
            ViewBag.FilterValues = new SelectList(await _context.thesis.Select(m => m.Status).Distinct().ToListAsync());
            //ViewBag.FilterValuesPublic = new SelectList(await _context.thesis.Select(m => m.Type).Distinct().ToListAsync());
            ViewBag.Sort = Sort;
            ViewBag.Page = Page;
            ViewBag.PageTotal = PageTotal;
            ViewBag.PageSize = PageSize;
            ViewBag.supervisor = _context.supervisors;
            if (!this.User.IsInRole("Administrator"))
                return View("publicThesis", await query.Skip(PageSize * (Page - 1)).Take(PageSize).ToListAsync());
            return View(await query.Skip(PageSize * (Page - 1)).Take(PageSize).ToListAsync());
        }

        // GET: Thesis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.thesis
                .Include(t => t.Supervisor)
                .Include(t => t.Programme)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (thesis == null)
            {
                return NotFound();
            }


            return View(thesis);
        }

        public async Task<IActionResult> DetailsPDF(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.thesis
                .Include(t => t.Supervisor)
                .Include(t => t.Programme)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (thesis == null)
            {
                return NotFound();
            }


            return new ViewAsPdf(thesis) { FileName = "Gutachten.pdf" };
        }


        // GET: Thesis/Create
        public IActionResult Create()
        {
            ViewData["SupervisorId"] = new SelectList(_context.supervisors, "Id", "LastName");

            ViewData["ProgrammeId"] = new SelectList(_context.programme, "Id", "Name");
            return View();
        }

        // POST: Thesis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind(
                "Id,LastModified,Title,Description,ProgrammeId,Status,Registration,Filing,Type,Summary,Bachelor,Master,StudentFirstName,StudentLastName,Email,StudentID,Strengths,Weaknesses,Evaluation,ContentVal,LayoutVal,StructureVal,StyleVal,LiteratureVal,DifficultyVal,NoveltyVal,RichnessVal,ContentWt,LayoutWt,StyleWt,LiteratureWt,StructureWt,DifficultyWt,NoveltyWt,RichnessWt,Grade,SupervisorId")]
            Thesis thesis)
        {
            if (ModelState.IsValid)
            {
                Validate(thesis);
                _context.Add(thesis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["SupervisorId"] = new SelectList(_context.supervisors, "Id", "LastName");
            ViewData["ProgrammeId"] = new SelectList(_context.programme, "Id", "Name");
            return View(thesis);
        }

        // GET: Thesis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.thesis.FindAsync(id);
            if (thesis == null)
            {
                return NotFound();
            }

            ViewData["SupervisorId"] = new SelectList(_context.supervisors, "Id", "LastName");
            ViewData["ProgrammeId"] = new SelectList(_context.programme, "Id", "Name");
            return View(thesis);
        }

        // POST: Thesis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind(
                "Id,LastModified,SupervisorId,ProgrammeId,Title,Description,Status,Registration,Filing,Type,Summary,Bachelor,Master,StudentFirstName,StudentLastName,Email,StudentID,Strengths,Weaknesses,Evaluation,ContentVal,LayoutVal,StructureVal,StyleVal,LiteratureVal,DifficultyVal,NoveltyVal,RichnessVal,ContentWt,LayoutWt,StyleWt,LiteratureWt,StructureWt,DifficultyWt,NoveltyWt,RichnessWt,Grade")]
            Thesis thesis, List<IFormFile> UploadFile)
        {
            if (id != thesis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var item in UploadFile)
                    {
                        if (item.Length > 0)
                        {
                            using (var stream = new MemoryStream())
                            {
                                await item.CopyToAsync(stream);
                                thesis.UploadFile = stream.ToArray();
                            }
                        }
                    }
                    _context.Update(thesis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThesisExists(thesis.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["SupervisorId"] = new SelectList(_context.supervisors, "Id", "LastName");
            ViewData["ProgrammeId"] = new SelectList(_context.programme, "Id", "Name");
            return View(thesis);
        }

        // GET: Thesis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.thesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thesis == null)
            {
                return NotFound();
            }

            return View(thesis);
        }

        // POST: Thesis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thesis = await _context.thesis.FindAsync(id);
            _context.thesis.Remove(thesis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThesisExists(int id)
        {
            return _context.thesis.Any(e => e.Id == id);
        }

        public IEnumerable<ValidationResult> Validate(Thesis thesis)
        {
            if (ModelState.IsValid)
            {
                // Sind Gewichtungen 100?
                if (thesis.ContentWt + thesis.LayoutWt + thesis.StructureWt + thesis.StyleWt + thesis.LiteratureWt +
                    thesis.DifficultyWt + thesis.NoveltyWt + thesis.RichnessWt != 100)
                {
                    int sum = thesis.ContentWt + thesis.LayoutWt + thesis.StructureWt + thesis.StyleWt +
                              thesis.LiteratureWt + thesis.DifficultyWt + thesis.NoveltyWt + thesis.RichnessWt;
                    return new ValidationResult[]
                        {new ValidationResult("Die Summe der Gewichtungen muss 100 sein, aber ist " + sum)};
                }
                // Ist Bachelor und/oder Master ausgewählt?
                else if (thesis.Bachelor == false && thesis.Master == false)
                {
                    throw new InvalidDataException("ja ne wähl mal was");
                }
                // Ist Anmeldedatum vor Abgabedatum?
                else if (thesis.Registration > thesis.Filing)
                {
                    return new ValidationResult[]
                        {new ValidationResult("Anmeldedatum muss vor dem Abgabedatum liegen!")};

                }
                // Was sollte alles eingetragen sein, wenn es Status benotet ist?
                else if ((thesis.Status == Status.Graded) && (thesis.Grade == Models.Grade.Note_Empty))
                {
                    return new ValidationResult[] { new ValidationResult("Bitte Note einfügen!") };

                }
                else if ((thesis.Status == Status.Graded) && (thesis.NoveltyVal == null || thesis.RichnessVal == null ||
                                                              thesis.StructureVal == null || thesis.StyleVal == null ||
                                                              thesis.LiteratureVal == null ||
                                                              thesis.LayoutVal == null ||
                                                              thesis.DifficultyVal == null ||
                                                              thesis.ContentVal == null))
                {
                    return new ValidationResult[] { new ValidationResult("Bitte alle Punkte einfügen!") };

                }
                // Was sollte alles eingetragen sein, wenn der Status registered, filed oder graded ist?
                else if ((thesis.Status == Status.Registered || thesis.Status == Status.Filed ||
                          thesis.Status == Status.Graded) && thesis.Registration == null)
                {
                    return new ValidationResult[] { new ValidationResult("Anmeldedatum einfügen!") };

                }
                else if ((thesis.Status == Status.Registered || thesis.Status == Status.Filed ||
                          thesis.Status == Status.Graded) &&
                         (thesis.StudentID == null || thesis.StudentFirstName == null ||
                          thesis.StudentLastName == null || thesis.Email == null))
                {
                    return new ValidationResult[]
                    {
                        new ValidationResult(
                            "Bitte Daten von Student eingeben (Matrikelnummer, Vorname, Nachname, E-Mail)!")
                    };

                }
                // Was sollte eingetragen sein, wenn der Status filed ist?
                else if ((thesis.Status == Status.Filed || thesis.Status == Status.Graded) && thesis.Filing == null)
                {
                    return new ValidationResult[] { new ValidationResult("Bitte Abgabedatum einfügen!") };
                }
            }

            return new ValidationResult[] { };
        }
        public async Task<IActionResult> Download(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            foreach (var thesis in _context.thesis)
            {
                if (thesis.Id.Equals(id))
                { 
                    return File(thesis.UploadFile, "application/pdf", "thesis.pdf");
                }
            }

            return NotFound();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}