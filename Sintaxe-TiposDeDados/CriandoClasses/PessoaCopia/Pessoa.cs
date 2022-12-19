using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriandoClasses.Models.PessoaCopia
{
    public class Pessoa
    {
        public string Nome { get; set; } //Atributos


        public int Idade { get; set; } //Atributos

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {this.Nome} e tenho {this.Idade} anos");

        }
    }
}