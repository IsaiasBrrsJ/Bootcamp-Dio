using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Models
{
    public static class Util
    {
        private static List<ItensVenda> _vendas = new List<ItensVenda>();
        public static void AdcionarVenda(ItensVenda venda)
        {
            _vendas.Add(venda);
        }

        public static List<ItensVenda> RetornaVendas()
        {
            return _vendas;
        }

        public static string AtualizarStatusVenda(int idVenda, StatusVenda statusVenda)
        {

            var indexVenda = verificaAtualizacaoStatusVenda(idVenda, statusVenda);

            if (indexVenda == -1)
                return "Opcao Invalida";

            if (indexVenda == -404)
                return "Venda nao localizada";

            _vendas[indexVenda].StatusVenda = statusVenda;

            return "Atualizado com sucesso";
        }
        private static int verificaAtualizacaoStatusVenda(int idVenda, StatusVenda statusVenda)
        {
            int indexVenda = -1;
            for (int i = 0; i < _vendas.Count; i++)
            {
                if (_vendas[i].Id == idVenda)
                {
                    indexVenda = i;
                    break;
                }
            }

            if (indexVenda == -1)
                return -404;


            if ((
                   _vendas[indexVenda].StatusVenda == StatusVenda.AguardandoPagamento &&
                    statusVenda == StatusVenda.PagamentoAprovado
                ) ||
                (
                    _vendas[indexVenda].StatusVenda == StatusVenda.AguardandoPagamento &&
                    statusVenda == StatusVenda.Cancelada
                ) ||
                (
                    _vendas[indexVenda].StatusVenda == StatusVenda.PagamentoAprovado &&
                    statusVenda == StatusVenda.EnviadoParaTransportadora
                ) ||
                (
                    _vendas[indexVenda].StatusVenda == StatusVenda.PagamentoAprovado &&
                    statusVenda == StatusVenda.Cancelada
                ) ||
                (
                    _vendas[indexVenda].StatusVenda == StatusVenda.EnviadoParaTransportadora &&
                    statusVenda == StatusVenda.Entregue
                )
              )
            {
                return indexVenda;
            }


            return -1;
        }
    }
}