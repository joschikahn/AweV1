using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AweV1.Data;
using AweV1.Models;
using Microsoft.AspNetCore.Authorization;

namespace AweV1.Controllers
{
    public class ThesisController : Controller
    {
        public enum SortCriteria
        {
            Title,
            Status,
            Registration,
            Filing,
            Type,
            StudentFirstName,
            StudentLastName,
            StudentID
        }

        private readonly AppDbContext _context;

        public ThesisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Thesis
        public async Task<IActionResult> Index()
        {
            return View(await _context.thesis.ToListAsync());
        }

        // GET: Thesis/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Thesis/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Thesis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("Id,LastModified,Title,Description,Status,Registration,Filing,Type,Summary,Bachelor,Master,StudentFirstName,StudentLastName,Email,StudentID,Strengths,Weaknesses,Evaluation,ContentVal,LayoutVal,StructureVal,StyleVal,LiteratureVal,DifficultyVal,NoveltyVal,RichnessVal,ContentWt,LayoutWt,StyleWt,LiteratureWt,StructureWt,DifficultyWt,NoveltyWt,RichnessWt,Grade")] Thesis thesis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thesis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
            return View(thesis);
        }

        // POST: Thesis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LastModified,Title,Description,Status,Registration,Filing,Type,Summary,Bachelor,Master,StudentFirstName,StudentLastName,Email,StudentID,Strengths,Weaknesses,Evaluation,ContentVal,LayoutVal,StructureVal,StyleVal,LiteratureVal,DifficultyVal,NoveltyVal,RichnessVal,ContentWt,LayoutWt,StyleWt,LiteratureWt,StructureWt,DifficultyWt,NoveltyWt,RichnessWt,Grade")] Thesis thesis)
        {
            if (id != thesis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
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
    }
}
