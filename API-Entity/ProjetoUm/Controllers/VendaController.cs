
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProjetoUm.Context;
using ProjetoUm.Models;
using ProjetoUm.Models.DTO;
using System.IO;
namespace ProjetoUm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly DataContext _context;
        public VendaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("BuscarVenda/{idVenda}")]
        public IActionResult SelectVendaId([FromRoute] int idVenda)
        {
            try
            {

                var venda = _context.Vendas.Include(x => x.Produtos).Include(x => x.Cliente).Include(x => x.Vendedor).Where(x => x.Id == idVenda).AsNoTracking().ToList<Venda>();



                return Ok(venda);
            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
        [HttpPost]
        [Route("VendaProduto/{idCliente}/{idVendedor}/{idProduto}")]
        public IActionResult InsertVenda([FromBody] VendaDTO vendaRequest, [FromRoute] int idCliente,
        [FromRoute] int idVendedor, [FromRoute] int idProduto)
        {
            try
            {
                var cliente = _context.Clientes.FirstOrDefault(x => x.Id == idCliente);
                var produto = _context.Produtos.FirstOrDefault(x => x.Id == idProduto);
                var vendedor = _context.Vendedores.FirstOrDefault(x => x.Id == idVendedor);

                if (cliente is null)
                    return NotFound(new { Erro = "Cliente não encontrado" });
                else if (produto is null)
                    return NotFound(new { Erro = "Produto não encontrado" });
                else if (vendedor is null)
                    return NotFound(new { Erro = "Vendedor não encontrado" });


                var venda = new Venda
                {
                    Cliente = cliente,
                    Produtos = new List<Produto> { produto },
                    Vendedor = vendedor,
                    StatusVenda = vendaRequest.StatusVenda,
                    ValorTotal = vendaRequest.ValorTotal
                };

                _context.Vendas.Add(venda);
                _context.SaveChanges();

                return CreatedAtAction(nameof(SelectVendaId), new { id = venda.Id }, venda);

            }
            catch
            {
                return BadRequest(new { Erro = "Erro ao processar informação" });
            }
        }
    }
}