using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUm.Models.DTO
{
    public class ProdutoDTO
    {
        public string Nome { get; set; } = String.Empty;
        public string Descricao { get; set; } = String.Empty;
        public decimal ValorUnitario { get; set; }
        public DateTime DataEntrada { get; set; }
        public int EstoqueQuantidade { get; set; } = 0;
    }
}