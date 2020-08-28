using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAIF2021.Data;
using DAIF2021.Models.DataModels;

namespace DAIF2021.Controllers.AppControllers
{
    public class AppSettingsController : Controller
    {
        private readonly DAIF2021Context _context;

        public AppSettingsController(DAIF2021Context context)
        {
            _context = context;
        }

        /// <summary>
        /// GameCategory
        /// </summary>
        /// <returns></returns>

        // GET: GameCategory
        public async Task<IActionResult> IndexSearchGameCategory()
        {
            return View(await _context.GameCategory.ToListAsync());
        }

        // GET: GameCategory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameCategory = await _context.GameCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameCategory == null)
            {
                return NotFound();
            }

            return View(gameCategory);
        }

        // GET: GameCategory/Create
        public IActionResult CreateGameCategory()
        {
            return View();
        }

        // POST: GameCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameCategoryName")] GameCategory gameCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameCategory);
        }

        // GET: GameCategory/Edit/5
        public async Task<IActionResult> EditGameCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameCategory = await _context.GameCategory.FindAsync(id);
            if (gameCategory == null)
            {
                return NotFound();
            }
            return View(gameCategory);
        }

        // POST: GameCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameCategoryName")] GameCategory gameCategory)
        {
            if (id != gameCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameCategoryExists(gameCategory.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexSearchGameCategory));
            }
            return View(gameCategory);
        }

        // GET: GameCategory/DeleteGameCategory/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameCategory = await _context.GameCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameCategory == null)
            {
                return NotFound();
            }

            return View(gameCategory);
        }

        // POST: GameCategory/DeleteGameCategory/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameCategory = await _context.GameCategory.FindAsync(id);
            _context.GameCategory.Remove(gameCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameCategoryExists(int id)
        {
            return _context.GameCategory.Any(e => e.Id == id);
        }

        /// <summary>
        /// GameStatus
        /// </summary>
        /// <returns></returns>

        // GET: GameStatus
        public async Task<IActionResult> IndexSearchGameStatus()
        {
            return View(await _context.GameStatus.ToListAsync());
        }

        // GET: GameStatus/Details/5
        public async Task<IActionResult> DetailsGameStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameStatus = await _context.GameStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameStatus == null)
            {
                return NotFound();
            }

            return View(gameStatus);
        }

        // GET: GameStatus/Create
        public IActionResult CreateGameStatus()
        {
            return View();
        }

        // POST: GameCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGameStatus([Bind("Id,GameStatusName")] GameStatus gameStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexSearchGameStatus));
            }
            return View(gameStatus);
        }

        // GET: GameStatus/Edit/5
        public async Task<IActionResult> EditGameStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameStatus = await _context.GameStatus.FindAsync(id);
            if (gameStatus == null)
            {
                return NotFound();
            }
            return View(gameStatus);
        }

        // POST: GameStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditGameStatus(int id, [Bind("Id,GameStatusName")] GameStatus gameStatus)
        {
            if (id != gameStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameCategoryExists(gameStatus.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexSearchGameStatus));
            }
            return View(gameStatus);
        }

        // GET: GameStatus/DeleteGameStatus/5
        public async Task<IActionResult> DeleteGameStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameStatus = await _context.GameStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameStatus == null)
            {
                return NotFound();
            }

            return View(gameStatus);
        }

        // POST: GameStatus/DeleteGameStatus/5
        [HttpPost, ActionName("DeleteGameStatus")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedGameStatus(int id)
        {
            var gameStatus = await _context.GameStatus.FindAsync(id);
            _context.GameStatus.Remove(gameStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexSearchGameStatus));
        }

        private bool GameStatusExists(int id)
        {
            return _context.GameStatus.Any(e => e.Id == id);
        }
    }
}
