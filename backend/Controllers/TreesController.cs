using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Backend_EXP.Data;
using Backend_EXP.Models;

namespace Backend_EXP.Controllers
{
    public class TreesController : Controller
    {
        private readonly Backend_EXPContext _context;

        public TreesController(Backend_EXPContext context)
        {
            _context = context;
        }

        // GET: Trees
        public async Task<IActionResult> Index()
        {
              return _context.Tree != null ? 
                          View(await _context.Tree.ToListAsync()) :
                          Problem("Entity set 'Backend_EXPContext.Tree'  is null.");
        }

        // GET: Trees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Tree == null)
            {
                return NotFound();
            }

            var tree = await _context.Tree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tree == null)
            {
                return NotFound();
            }

            return View(tree);
        }

        // GET: Trees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SoilType,MinHeight,MaxHeight,CO2AbsorptionRate,CH2AbsorptionRate,ScientificName")] Tree tree)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tree);
        }

        // GET: Trees/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Tree == null)
            {
                return NotFound();
            }

            var tree = await _context.Tree.FindAsync(id);
            if (tree == null)
            {
                return NotFound();
            }
            return View(tree);
        }

        // POST: Trees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,SoilType,MinHeight,MaxHeight,CO2AbsorptionRate,CH2AbsorptionRate,ScientificName")] Tree tree)
        {
            if (id != tree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TreeExists(tree.Id))
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
            return View(tree);
        }

        // GET: Trees/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Tree == null)
            {
                return NotFound();
            }

            var tree = await _context.Tree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tree == null)
            {
                return NotFound();
            }

            return View(tree);
        }

        // POST: Trees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Tree == null)
            {
                return Problem("Entity set 'Backend_EXPContext.Tree'  is null.");
            }
            var tree = await _context.Tree.FindAsync(id);
            if (tree != null)
            {
                _context.Tree.Remove(tree);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TreeExists(string id)
        {
          return (_context.Tree?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
