using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MODULOAPI.Context;
using MODULOAPI.Models;

namespace MODULOAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController([FromServices] AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("CriarContato")]
        public IActionResult Create([FromBody] Contato contato)
        {
            _context.Contatos.Add(contato);

            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
        }

        [HttpGet]
        [Route("ObterTodosContatos")]
        public IActionResult SelectAll()
        {
            var selectAll = (from c in _context.Contatos select c).ToList<Contato>();

            return Ok(selectAll);
        }

        [HttpGet]
        [Route("ObterPorId/{id}")]
        public IActionResult ObterPorId([FromRoute] int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            { return NotFound(); }

            return Ok(contato);
        }

        [HttpGet]
        [Route("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome([FromRoute] string nome)
        {
            var contatoBanco = _context.Contatos.Where(x => x.Nome.Contains(nome)).ToList<Contato>();

            if (contatoBanco == null)
                return NotFound();


            return Ok(contatoBanco);
        }
        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();


            contatoBanco.Ativo = contato.Ativo;
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();


            return ObterPorId(contatoBanco.Id);
        }

        [HttpDelete]
        [Route("Deletar/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();


            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();


            return NoContent(); // deletou e nao tem nada mais pra mostrar
        }
    }
}