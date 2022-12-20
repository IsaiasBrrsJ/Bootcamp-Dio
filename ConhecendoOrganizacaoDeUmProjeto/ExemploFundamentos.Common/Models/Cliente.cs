using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public void Aprensentacao()
        {
            Console.WriteLine("Se apresentando");
        }
    }
}