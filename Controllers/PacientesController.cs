using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CntNetCore.Data;
using CntNetCore.Models;

namespace CntNetCore.Controllers
{
    public class PacientesController : Controller
    {
        private readonly CntNetCoreContext _context;

        public PacientesController(CntNetCoreContext context)
        {
            _context = context;
        }

        // GET: Pacientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pacientes.ToListAsync());
        }

        public async Task<IActionResult> Prioridad()
        {
            string query = "SELECT * FROM Pacientes WHERE (Estado ='Pendiente') ORDER BY Prioridad DESC";

            return View(await _context.Pacientes.FromSqlRaw(query).ToListAsync());
        }
        public async Task<IActionResult> Riesgo()
        {
            string query = "SELECT * FROM Pacientes WHERE (Estado ='Pendiente') ORDER BY Riesgo DESC";

            return View(await _context.Pacientes.FromSqlRaw(query).ToListAsync());
        }
        public async Task<IActionResult> Atender(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await _context.Database.ExecuteSqlInterpolatedAsync(
                $"UPDATE Pacientes set Estado='Atendido' where Documento={id} ");

            string query = "SELECT * FROM Pacientes WHERE (Estado ='Pendiente') ORDER BY Prioridad DESC";

            return View(await _context.Pacientes.FromSqlRaw(query).ToListAsync());

        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Atender(string id, [Bind("Documento,Estado")] Pacientes pacientes)
        {

            await _context.Database.ExecuteSqlInterpolatedAsync(
                $"UPDATE Pacientes set Estado='Atendido' where Documento={id} ");

            string query = "SELECT * FROM Pacientes WHERE (Estado ='Pendiente') ORDER BY Prioridad DESC";

            return View(await _context.Pacientes.FromSqlRaw(query).ToListAsync());
        }

        public async Task<IActionResult> AtenderR(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await _context.Database.ExecuteSqlInterpolatedAsync(
                $"UPDATE Pacientes set Estado='Atendido' where Documento={id} ");

            string query = "SELECT * FROM Pacientes WHERE (Estado ='Pendiente') ORDER BY Riesgo DESC";

            return View(await _context.Pacientes.FromSqlRaw(query).ToListAsync());

        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtenderR(string id, [Bind("Documento,Estado")] Pacientes pacientes)
        {

            await _context.Database.ExecuteSqlInterpolatedAsync(
                $"UPDATE Pacientes set Estado='Atendido' where Documento={id} ");

            string query = "SELECT * FROM Pacientes WHERE (Estado ='Pendiente') ORDER BY Riesgo DESC";

            return View(await _context.Pacientes.FromSqlRaw(query).ToListAsync());
        }

        // GET: Pacientes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacientes = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Documento == id);
            if (pacientes == null)
            {
                return NotFound();
            }

            return View(pacientes);
        }

        // GET: Pacientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Documento,Nombres,Apellidos,Edad,Direccion,Sexo,Peso,Estatura,Fumador,Añosfumador,Dieta,PesoEstatura,Estado,Riesgo,Prioridad")] Pacientes pacientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pacientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pacientes);
        }

        // GET: Pacientes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacientes = await _context.Pacientes.FindAsync(id);
            if (pacientes == null)
            {
                return NotFound();
            }
            return View(pacientes);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Documento,Nombres,Apellidos,Edad,Direccion,Sexo,Peso,Estatura,Fumador,Añosfumador,Dieta,PesoEstatura,Estado,Riesgo,Prioridad")] Pacientes pacientes)
        {
            if (id != pacientes.Documento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pacientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacientesExists(pacientes.Documento))
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
            return View(pacientes);
        }

        // GET: Pacientes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacientes = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Documento == id);
            if (pacientes == null)
            {
                return NotFound();
            }

            return View(pacientes);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pacientes = await _context.Pacientes.FindAsync(id);
            _context.Pacientes.Remove(pacientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacientesExists(string id)
        {
            return _context.Pacientes.Any(e => e.Documento == id);
        }

        
    }
}
