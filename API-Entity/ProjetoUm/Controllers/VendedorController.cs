using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoUm.Context;
using ProjetoUm.Models;
using ProjetoUm.Models.DTO;

namespace ProjetoUm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly DataContext _context;
        public VendedorController([FromServices] DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("AdcionarVendedor/{rua}/{numeroCasa}")]
        public IActionResult InsertVendedor([FromRoute] string rua, [FromRoute] string numeroCasa,
        [FromBody] VendedorDTO vendedorRequest)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Numero == numeroCasa && e.Rua == rua);
            try
            {
                if (endereco is null)
                    return NotFound(new { NotFound = "Endereço não encontrado" });

                var vendedor = new Vendedor
                {
                    CPF = vendedorRequest.CPF,
                    Email = vendedorRequest.Email,
                    Nome = vendedorRequest.Nome,
                    Telefone = vendedorRequest.Telefone,
                    Endereco = endereco
                };

                _context.Vendedores.Add(vendedor);
                _context.SaveChanges();

                return Ok(new { Sucesso = "Salvo com sucesso" });
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpGet]
        [Route("ObterCliente/{id}")]
        public IActionResult SelectVendedorId([FromRoute] int id)
        {
            try
            {
                var vendedorFind = _context.Vendedores.FirstOrDefault(c => c.Id == id);

                if (vendedorFind is null)
                    return NotFound(new { NotFound = "Vendedor não encontrado" });


                return Ok(vendedorFind);
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpPut]
        [Route("AtualizarVendedor/{id}")]
        public IActionResult UpdateVendedor([FromRoute] int id, [FromBody] VendedorDTO vendedorRequest)
        {
            try
            {
                var vendedorFind = _context.Vendedores.FirstOrDefault(c => c.Id == id);

                if (vendedorFind is null)
                    return NotFound(new { NotFound = "Vendedor não encontrado" });

                vendedorFind.CPF = vendedorRequest.CPF;
                vendedorFind.Email = vendedorRequest.Email;
                vendedorFind.Nome = vendedorRequest.Nome;
                vendedorFind.Telefone = vendedorRequest.Telefone;


                _context.Vendedores.Update(vendedorFind);
                _context.SaveChanges();

                return CreatedAtAction(nameof(SelectVendedorId), new { id = vendedorFind.Id }, vendedorRequest);
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpDelete]
        [Route("DeleteVendedor/{id}")]
        public IActionResult DeleteVendedor([FromRoute] int id)
        {
            try
            {
                var vendedorFind = _context.Vendedores.FirstOrDefault(c => c.Id == id);

                if (vendedorFind is null)
                    return NotFound(new { NotFound = "Vendedor não encontrado" });


                _context.Vendedores.Remove(vendedorFind);
                _context.SaveChanges();


                return NoContent();
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }

    }
}