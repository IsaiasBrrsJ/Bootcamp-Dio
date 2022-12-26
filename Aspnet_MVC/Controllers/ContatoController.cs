using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspnet_MVC.Context;
using Aspnet_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aspnet_MVC.Controllers
{
    public class ContatoController : Controller
    {

        private readonly AgendaContext _context;

        public ContatoController([FromServices] AgendaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            try
            {
                var contatos = _context.Contatos.ToList();

                return View(contatos);
            }
            catch
            {
                return BadRequest();
            }
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            try
            {
                var contato = _context.Contatos.Find(id);

                if (contato == null)
                    return RedirectToAction(nameof(Index));


                return View(contato);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Contato contato)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(contato);

                await _context.Contatos.AddAsync(contato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Contato contato)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();


                var contatoBanco = await _context.Contatos.FindAsync(contato.Id);

                contatoBanco.Nome = contato.Nome;
                contatoBanco.Ativo = contato.Ativo;
                contatoBanco.Telefone = contato.Telefone;


                _context.Contatos.Update(contatoBanco);

                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }

        }
        public async Task<IActionResult> Detalhes(int id)
        {
            try
            {
                var contato = await _context.Contatos.FindAsync(id);

                if (contato is null)
                {
                    return NotFound();
                }


                return View(contato);
            }
            catch
            {
                return BadRequest();
            }


        }

        public IActionResult Deletar(int id)
        {

            try
            {
                var contato = _context.Contatos.Find(id);

                if (contato == null)
                    return RedirectToAction(nameof(Index));


                return View(contato);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Deletar(Contato contato)
        {
            try
            {
                var contatoBanco = await _context.Contatos.FindAsync(contato.Id);

                if (contatoBanco is null)
                    return NotFound();

                _context.Contatos.Remove(contatoBanco);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}