using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MinhQuan_DotNetCoreMVC5_Demo.Models.Entities;

namespace MinhQuan_DotNetCoreMVC5_Demo.Controllers
{
    public class DemoUsersController : Controller
    {
        private readonly Demo_DotNetCore50MVCContext _context;

        public DemoUsersController(Demo_DotNetCore50MVCContext context)
        {
            _context = context;
        }

        // GET: DemoUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.DemoUsers.ToListAsync());
        }

        // GET: DemoUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoUser = await _context.DemoUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demoUser == null)
            {
                return NotFound();
            }

            return View(demoUser);
        }

        // GET: DemoUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DemoUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Phone,Address")] DemoUser demoUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demoUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demoUser);
        }

        // GET: DemoUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoUser = await _context.DemoUsers.FindAsync(id);
            if (demoUser == null)
            {
                return NotFound();
            }
            return View(demoUser);
        }

        // POST: DemoUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Phone,Address")] DemoUser demoUser)
        {
            if (id != demoUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demoUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemoUserExists(demoUser.Id))
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
            return View(demoUser);
        }

        // GET: DemoUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demoUser = await _context.DemoUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demoUser == null)
            {
                return NotFound();
            }

            return View(demoUser);
        }

        // POST: DemoUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var demoUser = await _context.DemoUsers.FindAsync(id);
            _context.DemoUsers.Remove(demoUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemoUserExists(int id)
        {
            return _context.DemoUsers.Any(e => e.Id == id);
        }
    }
}
