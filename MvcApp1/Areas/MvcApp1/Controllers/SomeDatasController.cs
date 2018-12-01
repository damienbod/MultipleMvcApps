using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcApp1.Areas.MvcApp1.Models;
using MvcApp1.Models;

namespace MvcApp1.Areas.MvcApp1.Controllers
{
    [Area("MvcApp1")]
    public class SomeDatasController : Controller
    {
        private readonly SomeDataContext _context;

        public SomeDatasController(SomeDataContext context)
        {
            _context = context;
        }

        // GET: MvcApp1/SomeDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.SomeData.ToListAsync());
        }

        // GET: MvcApp1/SomeDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var someData = await _context.SomeData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (someData == null)
            {
                return NotFound();
            }

            return View(someData);
        }

        // GET: MvcApp1/SomeDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MvcApp1/SomeDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Details")] SomeData someData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(someData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(someData);
        }

        // GET: MvcApp1/SomeDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var someData = await _context.SomeData.FindAsync(id);
            if (someData == null)
            {
                return NotFound();
            }
            return View(someData);
        }

        // POST: MvcApp1/SomeDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Details")] SomeData someData)
        {
            if (id != someData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(someData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SomeDataExists(someData.Id))
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
            return View(someData);
        }

        // GET: MvcApp1/SomeDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var someData = await _context.SomeData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (someData == null)
            {
                return NotFound();
            }

            return View(someData);
        }

        // POST: MvcApp1/SomeDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var someData = await _context.SomeData.FindAsync(id);
            _context.SomeData.Remove(someData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SomeDataExists(int id)
        {
            return _context.SomeData.Any(e => e.Id == id);
        }
    }
}
