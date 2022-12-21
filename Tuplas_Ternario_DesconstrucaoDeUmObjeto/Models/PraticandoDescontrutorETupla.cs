using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_Ternario_DesconstrucaoDeUmObjeto.Models
{
    public class PraticandoDescontrutorETupla
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public PraticandoDescontrutorETupla(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Deconstruct(out string nome, out int idade)
        {
            // o nome do metodo deve ser exatamento dessa maneira => Deconstruct

            nome = Nome;
            idade = Idade;
        }
        public (string nome, int idade) TuplasTeste()
        {

            return (Nome, Idade);
        }
    }
}