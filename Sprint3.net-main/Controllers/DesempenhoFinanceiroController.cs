using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sprint3.Models;
using Sprint3.Persistence;

namespace Sprint3.Controllers
{
    public class DesempenhoFinanceiroController : Controller
    {
        private readonly OracleDbContext _context;

        public DesempenhoFinanceiroController(OracleDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.DesempenhoFinanceiro.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempenhoFinanceiro = await _context.DesempenhoFinanceiro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desempenhoFinanceiro == null)
            {
                return NotFound();
            }

            return View(desempenhoFinanceiro);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Receita,Lucro,Crescimento")] DesempenhoFinanceiro desempenhoFinanceiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(desempenhoFinanceiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(desempenhoFinanceiro);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempenhoFinanceiro = await _context.DesempenhoFinanceiro.FindAsync(id);
            if (desempenhoFinanceiro == null)
            {
                return NotFound();
            }
            return View(desempenhoFinanceiro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Receita,Lucro,Crescimento")] DesempenhoFinanceiro desempenhoFinanceiro)
        {
            if (id != desempenhoFinanceiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(desempenhoFinanceiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesempenhoFinanceiroExists(desempenhoFinanceiro.Id))
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
            return View(desempenhoFinanceiro);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempenhoFinanceiro = await _context.DesempenhoFinanceiro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desempenhoFinanceiro == null)
            {
                return NotFound();
            }

            return View(desempenhoFinanceiro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var desempenhoFinanceiro = await _context.DesempenhoFinanceiro.FindAsync(id);
            if (desempenhoFinanceiro != null)
            {
                _context.DesempenhoFinanceiro.Remove(desempenhoFinanceiro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesempenhoFinanceiroExists(long id)
        {
            return _context.DesempenhoFinanceiro.Any(e => e.Id == id);
        }
    }
}
