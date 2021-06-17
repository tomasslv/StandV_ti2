using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StandV_ti2.Data;
using StandV_ti2.Models;

namespace StandV_ti2.Controllers
{
    public class ReparacoesController : Controller
    {
        private readonly ReparacaoDB _context;

        public ReparacoesController(ReparacaoDB context)
        {
            _context = context;
        }

        // GET: Reparacoes
        public async Task<IActionResult> Index()
        {
            var reparacaoDB = _context.Reparacoes.Include(r => r.Gestor).Include(r => r.Veiculo);
            return View(await reparacaoDB.ToListAsync());
        }

        // GET: Reparacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reparacoes = await _context.Reparacoes
                .Include(r => r.Gestor)
                .Include(r => r.Veiculo)
                .FirstOrDefaultAsync(m => m.IdReparacao == id);
            if (reparacoes == null)
            {
                return NotFound();
            }

            return View(reparacoes);
        }

        // GET: Reparacoes/Create
        public IActionResult Create()
        {
            ViewData["IdGestor"] = new SelectList(_context.Gestores, "IdGestor", "CodPostal");
            ViewData["IdVeiculo"] = new SelectList(_context.Veiculos, "IdVeiculo", "Marca");
            return View();
        }

        // POST: Reparacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReparacao,IdVeiculo,IdGestor,TipoAvaria,DataRepar,Descricao,Estado")] Reparacoes reparacoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reparacoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdGestor"] = new SelectList(_context.Gestores, "IdGestor", "CodPostal", reparacoes.IdGestor);
            ViewData["IdVeiculo"] = new SelectList(_context.Veiculos, "IdVeiculo", "Marca", reparacoes.IdVeiculo);
            return View(reparacoes);
        }

        // GET: Reparacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reparacoes = await _context.Reparacoes.FindAsync(id);
            if (reparacoes == null)
            {
                return NotFound();
            }
            ViewData["IdGestor"] = new SelectList(_context.Gestores, "IdGestor", "CodPostal", reparacoes.IdGestor);
            ViewData["IdVeiculo"] = new SelectList(_context.Veiculos, "IdVeiculo", "Marca", reparacoes.IdVeiculo);
            return View(reparacoes);
        }

        // POST: Reparacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdReparacao,IdVeiculo,IdGestor,TipoAvaria,DataRepar,Descricao,Estado")] Reparacoes reparacoes)
        {
            if (id != reparacoes.IdReparacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reparacoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReparacoesExists(reparacoes.IdReparacao))
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
            ViewData["IdGestor"] = new SelectList(_context.Gestores, "IdGestor", "CodPostal", reparacoes.IdGestor);
            ViewData["IdVeiculo"] = new SelectList(_context.Veiculos, "IdVeiculo", "Marca", reparacoes.IdVeiculo);
            return View(reparacoes);
        }

        // GET: Reparacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reparacoes = await _context.Reparacoes
                .Include(r => r.Gestor)
                .Include(r => r.Veiculo)
                .FirstOrDefaultAsync(m => m.IdReparacao == id);
            if (reparacoes == null)
            {
                return NotFound();
            }

            return View(reparacoes);
        }

        // POST: Reparacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reparacoes = await _context.Reparacoes.FindAsync(id);
            _context.Reparacoes.Remove(reparacoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReparacoesExists(int id)
        {
            return _context.Reparacoes.Any(e => e.IdReparacao == id);
        }
    }
}
