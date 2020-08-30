using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAIF2021.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DAIF2021.Controllers.AppControllers
{
    public class TSMGamesController : Controller
    {
        private readonly DAIF2021Context _context;

        public TSMGamesController(DAIF2021Context context)
        {
            _context = context;
        }


        // GET: TSMGames
        public async Task<IActionResult> Index()
        {
            return View(await _context.TSMGame.ToListAsync());
        }
        // GET: TSMGames //GetTSMGames Search
        public async Task<IActionResult> IndexSearch
            (string searchString, string searchString1
            ,string searchString2, string searchString3)
        {
            var tSMGames = from t in _context.TSMGame
                           .Include(t => t.TSMGameStatus)

                         select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                tSMGames = tSMGames
                    .Where(s => s.GameNumber.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                tSMGames = tSMGames
                    .Where(s => s.Arena.Contains(searchString1));
            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                tSMGames = tSMGames
                    .Where(s => s.GameDateTime.ToString().Contains(searchString2));
            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                tSMGames = tSMGames
                    .Where(s => s.TSMGameStatus.TSMGameStatusName.Contains(searchString3));
            }
            return View(await tSMGames.ToListAsync());
        }

        // GET: TSMGamesController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMGame = await _context.TSMGame
                .Include(t => t.TSMGameStatus)
                .FirstOrDefaultAsync(t => t.Id == id);
            if(tSMGame == null)
            {
                return NotFound();
            }

            return View(tSMGame);
        }
       
        // GET: TSMGamesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TSMGamesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TSMGamesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TSMGamesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TSMGamesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TSMGamesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
