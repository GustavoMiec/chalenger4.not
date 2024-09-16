using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sprint3.Models;
using Sprint3.Persistence;

namespace Sprint3.Controllers
{
    public class TendenciasGastosController : Controller
    {
        private readonly OracleDbContext _context;

        public TendenciasGastosController(OracleDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.TendenciasGastos.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tendenciasGastos = await _context.TendenciasGastos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tendenciasGastos == null)
            {
                return NotFound();
            }

            return View(tendenciasGastos);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ano,GastoMarketing,GastoAutomacao")] TendenciasGastos tendenciasGastos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tendenciasGastos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tendenciasGastos);
        }

        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tendenciasGastos = await _context.TendenciasGastos.FindAsync(id);
            if (tendenciasGastos == null)
            {
                return NotFound();
            }
            return View(tendenciasGastos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Ano,GastoMarketing,GastoAutomacao")] TendenciasGastos tendenciasGastos)
        {
            if (id != tendenciasGastos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tendenciasGastos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TendenciasGastosExists(tendenciasGastos.Id))
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
            return View(tendenciasGastos);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tendenciasGastos = await _context.TendenciasGastos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tendenciasGastos == null)
            {
                return NotFound();
            }

            return View(tendenciasGastos);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var tendenciasGastos = await _context.TendenciasGastos.FindAsync(id);
            if (tendenciasGastos != null)
            {
                _context.TendenciasGastos.Remove(tendenciasGastos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TendenciasGastosExists(long id)
        {
            return _context.TendenciasGastos.Any(e => e.Id == id);
        }
    }
}
