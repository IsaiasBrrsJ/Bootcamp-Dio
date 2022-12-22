using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meun nome é {Nome}. tenho {Idade} anos, e sou um professor  e ganho: {Salario:C}");
        }
    }
}