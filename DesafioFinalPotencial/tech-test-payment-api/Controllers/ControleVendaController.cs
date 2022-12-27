using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Models;


namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControleVendaController : ControllerBase
    {

        [HttpGet]
        [Route("BuscarVendaId/{id}")]
        public IActionResult BuscarPorId([FromRoute] int id)
        {
            var vendido = Util.RetornaVendas().Where(v => v.Id == id).FirstOrDefault();

            if (vendido == null)
                return NotFound(new { NotFound = "Venda não localizada" });


            return Ok(vendido);
        }

        [HttpPost]
        [Route("RegistraVenda")]
        public IActionResult RegistraVenda([FromBody] ItensVenda venda)
        {
            if (venda.QuantidadePedido < 1)
                return BadRequest(new { Error = "Deve haver pelo menos um pedido" });


            Util.AdcionarVenda(venda);
            var vendido = Util.RetornaVendas().Where(v => v.Id == venda.Id);

            return Ok(vendido);
        }

        [HttpPut]
        [Route("AtualizarVenda/{idVenda}")]
        public IActionResult AtualizarVenda([FromRoute] int idVenda, StatusVenda status)
        {

            var atualizarVenda = Util.AtualizarStatusVenda(idVenda, status);

            if (atualizarVenda == "Atualizado com sucesso")
                return Ok(new { Atualizado = atualizarVenda });

            else if (atualizarVenda == "Venda nao localizada")
                return NotFound(new { NotFound = atualizarVenda });

            else
            {

                StringBuilder atualizacaoPermitida = new StringBuilder();
                atualizacaoPermitida.AppendLine("Erro, Status de atualizações permitidos:");

                atualizacaoPermitida.Append("{ ");
                atualizacaoPermitida.AppendLine("");
                atualizacaoPermitida.AppendLine("    De:Aguardando pagamento Para: Pagamento Aprovado");
                atualizacaoPermitida.AppendLine("    De: Aguardando pagamento Para: Cancelada");
                atualizacaoPermitida.AppendLine("    De: Pagamento Aprovado Para: Enviado para Transportadora");
                atualizacaoPermitida.AppendLine("    De: Pagamento Aprovado Para: Cancelada");
                atualizacaoPermitida.AppendLine("    De: Enviado para Transportador.Para: Entregue ");
                atualizacaoPermitida.AppendLine("}");

                return BadRequest(atualizacaoPermitida.ToString());
            }
        }
    }
}