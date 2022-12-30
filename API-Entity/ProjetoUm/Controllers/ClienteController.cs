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
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController([FromServices] DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AdcionarCliente/{rua}/{numeroCasa}")]
        public IActionResult InsertCliente([FromRoute] string rua, [FromRoute] string numeroCasa,
         [FromBody] ClienteDTO clienteRequest)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Numero == numeroCasa && e.Rua == rua);
            try
            {
                if (endereco is null)
                {
                    return NotFound(new { Erro = "Endereço não encontrado" });
                }

                var cliente = new Cliente
                {
                    Nome = clienteRequest.Nome,
                    CPF = clienteRequest.CPF,
                    Endereco = endereco
                };

                _context.Add(cliente);
                _context.SaveChanges();

                return Ok(new { Sucesso = "Salvo com sucesso" });
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }

        [HttpDelete]
        [Route("DeletarCliente/{id}")]
        public IActionResult DeleteCliente([FromRoute] int id)
        {
            try
            {
                var clienteFind = _context.Clientes.FirstOrDefault(c => c.Id == id);

                if (clienteFind is null)
                    return NotFound(new { Erro = "Cliente não encontrado" });



                _context.Clientes.Remove(clienteFind);
                _context.SaveChanges();

                return NoContent();
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }

        [HttpPut]
        [Route("UpdateCliente/{id}")]
        public IActionResult UpdateCliente([FromRoute] int id, [FromBody] ClienteDTO clienteRequest)
        {
            try
            {
                var clienteFind = _context.Clientes.FirstOrDefault(c => c.Id == id);

                if (clienteFind is null)
                    return NotFound(new { Erro = "Cliente não encontrado" });

                clienteFind.Nome = clienteRequest.Nome;
                clienteFind.CPF = clienteRequest.CPF;

                _context.Clientes.Update(clienteFind);

                _context.SaveChanges();

                return Ok(new { Erro = "Cliente atualizado com sucesso" });

            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpGet]
        [Route("ObterCliente/{id}")]
        public IActionResult GetClienteId([FromRoute] int id)
        {
            try
            {
                var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

                if (cliente is null)
                    return NotFound(new { Erro = "Cliente não encontrado" });

                return Ok(cliente);
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }

        }

    }
}