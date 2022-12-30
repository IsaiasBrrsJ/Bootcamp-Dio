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
    public class FornecedorController : ControllerBase
    {
        private readonly DataContext _context;
        public FornecedorController([FromServices] DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("AdcionarFornecedor/{id}")]
        public IActionResult InsertFornecedor([FromBody] FornecedorDTO fornecedorRequest, [FromRoute] int id)
        {

            try
            {
                var endereco = _context.Enderecos.FirstOrDefault(c => c.Id == id);

                if (endereco is null)
                    return NotFound(new { notFound = "Endereço não encontrado" });

                var fornecedor = new Fornecedor
                {
                    CNPJ = fornecedorRequest.CNPJ,
                    Endereco = endereco,
                    NomeFantasia = fornecedorRequest.NomeFantasia,
                    RazaoSocial = fornecedorRequest.RazaoSocial,
                };

                _context.Fornecedores.Add(fornecedor);
                _context.SaveChanges();
                return Ok(fornecedorRequest);
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet]
        [Route("BuscarFornecedor/{id}")]
        public IActionResult SelectFornecedorPorId([FromRoute] int id)
        {
            try
            {
                var fornecedor = _context.Fornecedores.FirstOrDefault(x => x.Id == id);

                if (fornecedor is null)
                    return NotFound(new { NotFound = "Fornecedor não encontrado" });

                return Ok(fornecedor);
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }

        [HttpPut]
        [Route("AtualizarFornecedor/{id}")]
        public IActionResult UpdateFornecedor([FromRoute] int id, [FromBody] FornecedorDTO fornecedorRequest)
        {
            try
            {
                var fornecedorFind = _context.Fornecedores.FirstOrDefault(c => c.Id == id);

                if (fornecedorFind is null)
                    return NotFound(new { NotFound = "Fornecedor não encontrado" });


                fornecedorFind.CNPJ = fornecedorRequest.CNPJ;
                fornecedorFind.RazaoSocial = fornecedorRequest.RazaoSocial;
                fornecedorFind.NomeFantasia = fornecedorRequest.NomeFantasia;

                _context.Fornecedores.Update(fornecedorFind);
                _context.SaveChanges();

                return CreatedAtAction(nameof(SelectFornecedorPorId), new { id = fornecedorFind.Id }, fornecedorRequest);

            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpDelete]
        [Route("DeletarFornecedor/{id}")]
        public IActionResult DeleteForncedor([FromRoute] int id)
        {
            try
            {
                var fornecedorFind = _context.Fornecedores.FirstOrDefault(c => c.Id == id);

                if (fornecedorFind is null)
                    return NotFound(new { NotFound = "Fornecedor não encontrado" });


                _context.Fornecedores.Remove(fornecedorFind);
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