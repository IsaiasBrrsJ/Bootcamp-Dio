using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoUm.Context;
using ProjetoUm.Models;
using ProjetoUm.Models.DTO;

namespace ProjetoUm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutoController([FromServices] DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("CadastrarProduto/{idFornecedor}")]
        public IActionResult InsertProduto([FromRoute] int idFornecedor, [FromBody] ProdutoDTO produtoRequest)
        {
            try
            {
                var forncedor = _context.Fornecedores.FirstOrDefault(c => c.Id == idFornecedor);

                if (forncedor is null)
                    return NotFound(new { NotFound = "Fornecedor não encontrado" });


                var produto = new Produto
                {
                    DataEntrada = DateTime.Now,
                    Descricao = produtoRequest.Descricao,
                    EstoqueQuantidade = produtoRequest.EstoqueQuantidade,
                    Nome = produtoRequest.Nome,
                    Fornecedor = forncedor,
                    ValorUnitario = produtoRequest.ValorUnitario,
                };

                _context.Produtos.Add(produto);
                _context.SaveChanges();

                return CreatedAtAction(nameof(SelectProdutoId), new { id = produto.Id }, produtoRequest);

            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpGet]
        [Route("BuscarProduto/{id}")]
        public IActionResult SelectProdutoId([FromRoute] int id)
        {
            try
            {
                var produto = _context.Produtos.FirstOrDefault(c => c.Id == id);

                if (produto is null)
                    return NotFound(new { NotFound = "Produto não encontrado" });


                return Ok(produto);
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpPut]
        [Route("AtualizarProduto/{id}")]
        public IActionResult UpdateProduto([FromRoute] int id, [FromBody] ProdutoDTO produtoRequest)
        {
            try
            {
                var produtoFind = _context.Produtos.FirstOrDefault(x => x.Id == id);

                if (produtoFind is null)
                    return NotFound(new { NotFound = "Produto não encontrado" });

                produtoFind.Nome = produtoRequest.Nome;
                produtoFind.Descricao = produtoRequest.Descricao;
                produtoFind.EstoqueQuantidade = produtoRequest.EstoqueQuantidade;
                produtoFind.ValorUnitario = produtoRequest.ValorUnitario;

                _context.Produtos.Update(produtoFind);
                _context.SaveChanges();

                return CreatedAtAction(nameof(SelectProdutoId), new { id = produtoFind.Id }, produtoRequest);

            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }

        [HttpDelete]
        [Route("DeletarProduto/{idProduto}")]
        public IActionResult DeleteProduto([FromRoute] int idProduto)
        {
            try
            {
                var produtoFind = _context.Produtos.FirstOrDefault(x => x.Id == idProduto);

                if (produtoFind is null)
                    return NotFound(new { NotFound = "Produto não encontrado" });


                _context.Produtos.Remove(produtoFind);
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