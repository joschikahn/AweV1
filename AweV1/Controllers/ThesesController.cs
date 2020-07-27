

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
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.SqlServer.Query.ExpressionTranslators.Internal;

namespace AweV1.Controllers
{
    public class ThesisController : Controller
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
           

            [Display(Name = "Alle anzeigen")]
            All = 0,

            [Display(Name = "Frei")]
            Free = 1,

            [Display(Name = "Vorgemerkt")]
            Reserved = 2,

            [Display(Name = "Angemeldet")]
            Registered = 3,

            [Display(Name = "Abgegeben")]
            Filed = 4,

            [Display(Name = "Bewertet")]
            Graded = 5
            
        
    }

        public enum PublicFilterEnum 
        {
            [Display(Name = "Alle anzeigen")]
            All = 0,

            [Display(Name = "Frei")]
            Free = 1,

            [Display(Name = "Vorgemerkt")]
            Reserved = 2
        }

        private readonly AppDbContext _context;

        public ThesisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Thesis
        public async Task<IActionResult> Index(string Search, FilterEnum Filter, PublicFilterEnum PublicFilter, SortCriteria Sort = SortCriteria.StudentLastName,
            int Page = 1, int PageSize = 10)
        {
            IQueryable<Thesis> query = _context.thesis;
            

            
            query = (Search != null) ? query.Where(m => (m.Title.Contains(Search))) : query;
            query = _context.thesis;
            if (!this.User.IsInRole("Administrator"))
            {
                //query = (PublicFilter.Equals(PublicFilterEnum.All)) ? query.Where(m => m.Status == Status.Free) || query.Where(m => m.Status == Status.Reserved) : query;
                /*if (PublicFilter.Equals(PublicFilterEnum.All))
                {
                   query = query.Where(m => m.Status == Status.Free || m.Status == Status.Registered);
                   //query = query.Where(m => m.Status == Status.Reserved);
                }
                else { query = query; }*/

                query = (PublicFilter.Equals(PublicFilterEnum.All)) ? query.Where(m => m.Status == Status.Free || m.Status == Status.Reserved) : query;
                query = (PublicFilter.Equals(PublicFilterEnum.Free)) ? query.Where(m => m.Status == Status.Free) : query;
                query = (PublicFilter.Equals(PublicFilterEnum.Reserved)) ? query.Where(m => m.Status == Status.Reserved) : query;
            }
            else
            {

                query = (Filter.Equals(FilterEnum.All)) ? _context.thesis : query;
                query = (Filter.Equals(FilterEnum.Free)) ? query.Where(m => m.Status == Status.Free) : query;
                query = (Filter.Equals(FilterEnum.Reserved)) ? query.Where(m => m.Status == Status.Reserved) : query;
                query = (Filter.Equals(FilterEnum.Registered)) ? query.Where(m => m.Status == Status.Registered) : query;
                query = (Filter.Equals(FilterEnum.Filed)) ? query.Where(m => m.Status == Status.Filed) : query;
                query = (Filter.Equals(FilterEnum.Graded)) ? query.Where(m => m.Status == Status.Graded) : query;
                query = (Filter.Equals(null)) ? _context.thesis : query;
            }

            

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
        [Authorize(Roles = "Administrator")]
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
        [Authorize(Roles = "Administrator")]
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


            return new ViewAsPdf(thesis) { FileName = "Gutachten "+thesis.Title +" "+thesis.StudentID+".pdf" };
        }


        // GET: Thesis/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            ViewData["SupervisorId"] = new SelectList(_context.supervisors, "Id", "LastName");
            List<SelectListItem> programme = new SelectList(_context.programme, "Id", "Name").ToList();
            programme.Insert(0,new SelectListItem(){Value= "0", Text = "- bitte auswählen -"});
            ViewData["ProgrammeId"] = programme;
            return View();
        }

        // POST: Thesis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create(
            [Bind(
                "Id,LastModified,Title,Description,ProgrammeId,Status,Registration,Filing,Type,Summary,Bachelor,Master,StudentFirstName,StudentLastName,Email,StudentID,Strengths,Weaknesses,Evaluation,ContentVal,LayoutVal,StructureVal,StyleVal,LiteratureVal,DifficultyVal,NoveltyVal,RichnessVal,ContentWt,LayoutWt,StyleWt,LiteratureWt,StructureWt,DifficultyWt,NoveltyWt,RichnessWt,Grade,SupervisorId")]
            Thesis thesis)
        {
            if (ModelState.IsValid)
            {
                if (thesis.ProgrammeId==0)
                {
                    thesis.ProgrammeId = null;
                    thesis.Programme = null;
                }
                _context.Add(thesis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["SupervisorId"] = new SelectList(_context.supervisors, "Id", "LastName");
            List<SelectListItem> programme = new SelectList(_context.programme, "Id", "Name").ToList();
            programme.Insert(0, new SelectListItem() { Value = "0", Text = "- bitte auswählen -" });
            ViewData["ProgrammeId"] = programme;
            return View(thesis);
        }

        // GET: Thesis/Edit/5
        [Authorize(Roles = "Administrator")]
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
        [Authorize(Roles = "Administrator")]
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
        [Authorize(Roles = "Administrator")]
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
        [Authorize(Roles = "Administrator")]
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
    }
}