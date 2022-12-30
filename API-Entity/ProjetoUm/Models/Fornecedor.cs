using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUm.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}