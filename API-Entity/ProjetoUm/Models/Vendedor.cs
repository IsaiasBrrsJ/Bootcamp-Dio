using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUm.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }


    }
}