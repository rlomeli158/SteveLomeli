using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace FinalProjectWorkspace.Controllers
{
    [Authorize(Roles = "Manager")]
    public class GenreController : Controller
    {
        private readonly AppDbContext _context;

        public GenreController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Genre
        public async Task<IActionResult> Index()
        {
            return View(await _context.Genres.ToListAsync());
        }

        // GET: Genre/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "Could not find this genre. Please Try Again." });
            }

            var genre = await _context.Genres
                .FirstOrDefaultAsync(m => m.GenreID == id);
            if (genre == null)
            {
                return View("Error2", new String[] { "Could not find this genre. Please Try Again." });
            }

            return View(genre);
        }

        // GET: Genre/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenreID,GenreName")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // GET: Genre/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "Could not edit this genre. Please Try Again." });
            }

            var genre = await _context.Genres.FindAsync(id);
            if (genre == null)
            {
                return View("Error2", new String[] { "Could not find this genre. Please Try Again." });
            }
            return View(genre);
        }

        // POST: Genre/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenreID,GenreName")] Genre genre)
        {
            if (id != genre.GenreID)
            {
                return View("Error2", new String[] { "Could not find this genre. Please Try Again." });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenreExists(genre.GenreID))
                    {
                        return View("Error2", new String[] { "Could not find this genre. Please Try Again." });
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // GET: Genre/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "Could not find this genre. Please Try Again." });
            }

            var genre = await _context.Genres
                .FirstOrDefaultAsync(m => m.GenreID == id);
            if (genre == null)
            {
                return View("Error2", new String[] { "Could not find this genre. Please Try Again." });
            }

            return View(genre);
        }

        // POST: Genre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            try {
                _context.Genres.Remove(genre);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return View("Error", new string[] { "This genre cannot be deleted as a Movie is currently associated with it. " +
                    "Please delete the movie first." });
                
            }
            return RedirectToAction(nameof(Index));
        }

        private bool GenreExists(int id)
        {
            return _context.Genres.Any(e => e.GenreID == id);
        }
    }
}
