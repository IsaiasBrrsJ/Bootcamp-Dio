using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoUm.Models.Enum;

namespace ProjetoUm.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public StatusVenda StatusVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public Vendedor Vendedor { get; set; }
        public int VendedorId { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }

    }
}