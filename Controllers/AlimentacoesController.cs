using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_1._0_eixo3_2024.Models;

namespace Projeto_1._0_eixo3_2024.Controllers
{
    [Authorize]
    public class AlimentacoesController : Controller
    {
        private readonly AppDbContext _context;

        public AlimentacoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Alimentacoes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Alimentacoes.Include(a => a.Cachorro);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Alimentacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.Alimentacoes
                .Include(a => a.Cachorro)
                .FirstOrDefaultAsync(m => m.IdAlimentacao == id);
            if (alimentacao == null)
            {
                return NotFound();
            }

            return View(alimentacao);
        }

        // GET: Alimentacoes/Create
        public IActionResult Create()
        {
            ViewData["IdCachorro"] = new SelectList(_context.Cachorros, "IdCachorro", "NomeCachorro");
            return View();
        }

        // POST: Alimentacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAlimentacao,NomeCachorro,HoraAlimentacao,Tipo,QuantidadeAlimentacao,UnidadeMedida,IdCachorro")] Alimentacao alimentacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alimentacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCachorro"] = new SelectList(_context.Cachorros, "IdCachorro", "NascimentoCachorro", alimentacao.IdCachorro);
            return View(alimentacao);
        }

        // GET: Alimentacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.Alimentacoes.FindAsync(id);
            if (alimentacao == null)
            {
                return NotFound();
            }
            ViewData["IdCachorro"] = new SelectList(_context.Cachorros, "IdCachorro", "NomeCachorro", alimentacao.IdCachorro);
            return View(alimentacao);
        }

        // POST: Alimentacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAlimentacao,HoraAlimentacao,Tipo,QuantidadeAlimentacao,UnidadeMedida,IdCachorro")] Alimentacao alimentacao)
        {
            if (id != alimentacao.IdAlimentacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alimentacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlimentacaoExists(alimentacao.IdAlimentacao))
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
            ViewData["IdCachorro"] = new SelectList(_context.Cachorros, "IdCachorro", "NascimentoCachorro", alimentacao.IdCachorro);
            return View(alimentacao);
        }

        // GET: Alimentacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentacao = await _context.Alimentacoes
                .Include(a => a.Cachorro)
                .FirstOrDefaultAsync(m => m.IdAlimentacao == id);
            if (alimentacao == null)
            {
                return NotFound();
            }

            return View(alimentacao);
        }

        // POST: Alimentacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alimentacao = await _context.Alimentacoes.FindAsync(id);
            if (alimentacao != null)
            {
                _context.Alimentacoes.Remove(alimentacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlimentacaoExists(int id)
        {
            return _context.Alimentacoes.Any(e => e.IdAlimentacao == id);
        }
    }
}
