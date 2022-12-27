using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Models
{
    public class ItensVenda
    {
        public int Id { get; set; }
        public Vendedor Vendedor { get; set; }

        public Produto Produto { get; set; }
        public DateTime DataVenda { get; set; }
        public int QuantidadePedido { get; set; }
        public StatusVenda StatusVenda { get; set; }


    }
}