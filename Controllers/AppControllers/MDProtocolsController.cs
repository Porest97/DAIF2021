using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAIF2021.Data;
using DAIF2021.Models.DataModels;

namespace DAIF2021.Controllers
{
    public class MDProtocolsController : Controller
    {
        private readonly DAIF2021Context _context;

        public MDProtocolsController(DAIF2021Context context)
        {
            _context = context;
        }

        // GET: MDProtocols
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MDProtocol
                .Include(m => m.Person);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MDProtocols/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mDProtocol = await _context.MDProtocol
                .Include(m => m.Person)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mDProtocol == null)
            {
                return NotFound();
            }

            return View(mDProtocol);
        }

        // GET: MDProtocols/DetailsPrint/5
        public async Task<IActionResult> DetailsPrint(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mDProtocol = await _context.MDProtocol
                .Include(m => m.Person)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mDProtocol == null)
            {
                return NotFound();
            }

            return View(mDProtocol);
        }

        // GET: MDProtocols/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            return View();
        }

        // POST: MDProtocols/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PersonId,Date,BodyTemp,SoreThroat,NasalCongestion,Cough,Headache,Nausea,Diarrhea,MuscleAches,OtherSymptoms,OtherSymptomsDescription,FamilySymtoms")] MDProtocol mDProtocol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mDProtocol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", mDProtocol.PersonId);
            return View(mDProtocol);
        }

        // GET: MDProtocols/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mDProtocol = await _context.MDProtocol.FindAsync(id);
            if (mDProtocol == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", mDProtocol.PersonId);
            return View(mDProtocol);
        }

        // POST: MDProtocols/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PersonId,Date,BodyTemp,SoreThroat,NasalCongestion,Cough,Headache,Nausea,Diarrhea,MuscleAches,OtherSymptoms,OtherSymptomsDescription,FamilySymtoms")] MDProtocol mDProtocol)
        {
            if (id != mDProtocol.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mDProtocol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MDProtocolExists(mDProtocol.Id))
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
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", mDProtocol.PersonId);
            return View(mDProtocol);
        }

        // GET: MDProtocols/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mDProtocol = await _context.MDProtocol
                .Include(m => m.Person)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mDProtocol == null)
            {
                return NotFound();
            }

            return View(mDProtocol);
        }

        // POST: MDProtocols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mDProtocol = await _context.MDProtocol.FindAsync(id);
            _context.MDProtocol.Remove(mDProtocol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MDProtocolExists(int id)
        {
            return _context.MDProtocol.Any(e => e.Id == id);
        }
    }
}
