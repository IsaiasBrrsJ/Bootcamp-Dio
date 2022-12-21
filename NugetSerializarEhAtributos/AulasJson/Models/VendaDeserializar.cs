using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace NugetSerializarEhAtributos.Models
{
    public class VendaDeserializar
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        [JsonProperty("Preco_Venda")]
        public decimal Preco { get; set; }

        public DateTime DataVenda { get; set; }
    }
}