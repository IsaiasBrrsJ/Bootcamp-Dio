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
    public class EnderecoController : ControllerBase
    {
        private readonly DataContext _context;

        public EnderecoController([FromServices] DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("AdcionarEndereco")]
        public IActionResult InsertEndereco([FromBody] EnderecoDTO enderecoRequest)
        {
            try
            {
                var enderecoCliente = new Endereco
                {
                    Rua = enderecoRequest.Rua,
                    Bairro = enderecoRequest.Bairro,
                    Cep = enderecoRequest.Cep,
                    Cidade = enderecoRequest.Cidade,
                    Complemento = enderecoRequest.Complemento,
                    Estado = enderecoRequest.Estado,
                    Numero = enderecoRequest.Numero
                };

                _context.Add(enderecoCliente);
                _context.SaveChanges();
                return Ok(new { Sucesso = "Salvo com sucesso" });
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }

        [HttpGet]
        [Route("ObterEndereco/{id}")]
        public IActionResult SelectEnderecoId([FromRoute] int id)
        {
            try
            {
                var endereco = _context.Enderecos.Where(p => p.Id == id);


                if (endereco is null)
                    return NotFound(new { notFound = "Endereço não encontrado" });


                return Ok(endereco);
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }

        [HttpPut]
        [Route("AtualizarEndereco/{id}")]
        public IActionResult UpdateEndereco([FromRoute] int id, [FromBody] EnderecoDTO enderecoRequest)
        {
            try
            {
                var buscarEndereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

                if (buscarEndereco is null)
                    return NotFound(new { notFound = "Endereço não encontrado" });

                buscarEndereco.Rua = enderecoRequest.Rua;
                buscarEndereco.Bairro = enderecoRequest.Bairro;
                buscarEndereco.Cep = enderecoRequest.Cep;
                buscarEndereco.Cidade = enderecoRequest.Cidade;
                buscarEndereco.Complemento = enderecoRequest.Complemento;
                buscarEndereco.Estado = enderecoRequest.Estado;
                buscarEndereco.Numero = enderecoRequest.Numero;

                _context.Enderecos.Update(buscarEndereco);
                _context.SaveChanges();

                return Ok(new { Sucesso = "Atualizado com sucesso" });
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpDelete]
        [Route("DeletarEndereco/{id}")]
        public IActionResult DeleteEndereco([FromRoute] int id)
        {
            try
            {
                var buscarEndereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

                if (buscarEndereco is null)
                    return NotFound(new { notFound = "Endereço não encontrado" });



                _context.Enderecos.Remove(buscarEndereco);
                _context.SaveChanges();

                return NoContent();
            }
            catch
            {
                return BadRequest(new { Erro = "Erro, o endereço está vinculado a um cliente" });
            }
        }


    }
}