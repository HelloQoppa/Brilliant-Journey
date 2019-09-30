using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGC.AppCore.Entity;
using SGC.Infrastructure.Data;

namespace SGC.UI.Controllers
{
    public class ProfissasController : Controller
    {
        private readonly ClienteContext _context;

        public ProfissasController(ClienteContext context)
        {
            _context = context;
        }

        // GET: Profissas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Profissoes.ToListAsync());
        }

        // GET: Profissas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissao = await _context.Profissoes
                .FirstOrDefaultAsync(m => m.ProfissaoId == id);
            if (profissao == null)
            {
                return NotFound();
            }

            return View(profissao);
        }

        // GET: Profissas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profissas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfissaoId,Nome,Descricao,CBO")] Profissao profissao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profissao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profissao);
        }

        // GET: Profissas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissao = await _context.Profissoes.FindAsync(id);
            if (profissao == null)
            {
                return NotFound();
            }
            return View(profissao);
        }

        // POST: Profissas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfissaoId,Nome,Descricao,CBO")] Profissao profissao)
        {
            if (id != profissao.ProfissaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profissao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfissaoExists(profissao.ProfissaoId))
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
            return View(profissao);
        }

        // GET: Profissas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissao = await _context.Profissoes
                .FirstOrDefaultAsync(m => m.ProfissaoId == id);
            if (profissao == null)
            {
                return NotFound();
            }

            return View(profissao);
        }

        // POST: Profissas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profissao = await _context.Profissoes.FindAsync(id);
            _context.Profissoes.Remove(profissao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfissaoExists(int id)
        {
            return _context.Profissoes.Any(e => e.ProfissaoId == id);
        }
    }
}
