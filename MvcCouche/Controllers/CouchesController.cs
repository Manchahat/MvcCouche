using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCouche.Data;
using MvcCouche.Models;

namespace MvcCouche.Controllers
{
    public class CouchesController : Controller
    {
        private readonly MvcCoucheContext _context;

        public CouchesController(MvcCoucheContext context)
        {
            _context = context;
        }

        // GET: Couches
        public async Task<IActionResult> Index()
        {
            return View(await _context.Couche.ToListAsync());
        }

        // GET: Couches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var couche = await _context.Couche
                .FirstOrDefaultAsync(m => m.Id == id);
            if (couche == null)
            {
                return NotFound();
            }

            return View(couche);
        }

        // GET: Couches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Couches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price,Colour,Height,Weight,Design,CountryOfOrigin")] Couche couche)
        {
            if (ModelState.IsValid)
            {
                _context.Add(couche);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(couche);
        }

        // GET: Couches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var couche = await _context.Couche.FindAsync(id);
            if (couche == null)
            {
                return NotFound();
            }
            return View(couche);
        }

        // POST: Couches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price,Colour,Height,Weight,Design,CountryOfOrigin")] Couche couche)
        {
            if (id != couche.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(couche);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoucheExists(couche.Id))
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
            return View(couche);
        }

        // GET: Couches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var couche = await _context.Couche
                .FirstOrDefaultAsync(m => m.Id == id);
            if (couche == null)
            {
                return NotFound();
            }

            return View(couche);
        }

        // POST: Couches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var couche = await _context.Couche.FindAsync(id);
            _context.Couche.Remove(couche);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoucheExists(int id)
        {
            return _context.Couche.Any(e => e.Id == id);
        }
    }
}
