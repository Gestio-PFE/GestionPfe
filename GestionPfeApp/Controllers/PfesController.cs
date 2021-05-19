using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionPfeApp.Data;
using GestionPfeApp.Models;

namespace GestionPfeApp.Controllers
{
    public class PfesController : Controller
    {
        private readonly EmiContext _context;

        public PfesController(EmiContext context)
        {
            _context = context;
        }

        // GET: Pfes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pfes.ToListAsync());
        }

        // GET: Pfes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pfe = await _context.Pfes
                .FirstOrDefaultAsync(m => m.PfeID == id);
            if (pfe == null)
            {
                return NotFound();
            }

            return View(pfe);
        }

        // GET: Pfes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pfes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PfeID,Titre,Mention,Note")] Pfe pfe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pfe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pfe);
        }

        // GET: Pfes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pfe = await _context.Pfes.FindAsync(id);
            if (pfe == null)
            {
                return NotFound();
            }
            return View(pfe);
        }

        // POST: Pfes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PfeID,Titre,Mention,Note")] Pfe pfe)
        {
            if (id != pfe.PfeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pfe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PfeExists(pfe.PfeID))
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
            return View(pfe);
        }

        // GET: Pfes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pfe = await _context.Pfes
                .FirstOrDefaultAsync(m => m.PfeID == id);
            if (pfe == null)
            {
                return NotFound();
            }

            return View(pfe);
        }

        // POST: Pfes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pfe = await _context.Pfes.FindAsync(id);
            _context.Pfes.Remove(pfe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PfeExists(int id)
        {
            return _context.Pfes.Any(e => e.PfeID == id);
        }
    }
}
