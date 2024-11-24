using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_1._0_eixo3_2024.Models;

namespace Projeto_1._0_eixo3_2024.Controllers
{
    [Authorize]
    public class CachorrosController : Controller
    {
        private readonly AppDbContext _context;
        public CachorrosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Cachorros.ToListAsync();

            return View(dados);
        }

//--CRIAR-----------------------------------------------------------------------------------------

        public IActionResult Create() //HttpGet
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cachorro cachorro)
        {
            if(ModelState.IsValid)
            {
                _context.Cachorros.Add(cachorro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cachorro);
        }

//--EDITAR----------------------------------------------------------------------------------------

        public async Task<IActionResult> Edit(int? id) //HttpGet
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cachorros.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cachorro cachorro)
        {
            if (id != cachorro.IdCachorro)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Cachorros.Update(cachorro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

//--VISUALIZAR------------------------------------------------------------------------------------

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cachorros.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

//--DELETE----------------------------------------------------------------------------------------

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cachorros.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Cachorros.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Cachorros.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //--HISTÓRICO----------------------------------------------------------------------------------------

        public async Task<IActionResult> Historico(int? id)
        {
            if (id == null)
                return NotFound();

            var cachorro = await _context.Cachorros.FindAsync(id);

            if(cachorro == null)
                return NotFound();

            var alimentacoes = await _context.Alimentacoes
                .Where(a => a.IdCachorro == id)
                .OrderByDescending(a => a.IdCachorro )
                .ToListAsync();

            decimal total = alimentacoes.Sum(a => a.QuantidadeAlimentacao);

            ViewBag.Cachorro = cachorro;
            ViewBag.Total = total;

            return View();
        }

    }
}
