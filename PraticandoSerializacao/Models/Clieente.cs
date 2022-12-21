using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticandoSerializacao.Models
{
    public class Clieente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Produto Produtos { get; set; }

        public Clieente(int id, string nome, Produto produto)
        {
            Id = id;
            Nome = nome;
            Produtos = produto;
        }
    }
}