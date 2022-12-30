using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoUm.Models.Enum;

namespace ProjetoUm.Models.DTO
{
    public class VendaDTO
    {

        public StatusVenda StatusVenda { get; set; }
        public decimal ValorTotal { get; set; }
    }
}