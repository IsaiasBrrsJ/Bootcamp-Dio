using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasEhInterfaces.Models
{
    public class Professor : Pessoa
    {
        public Professor() { }

        public Professor(string nome) : base(nome) { }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meun nome é {Nome}. tenho {Idade} anos, e sou um professor  e ganho: {Salario:C}");
        }
    }
}