using NugetSerializarEhAtributos.Models;
using Newtonsoft.Json;

Console.Clear();

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<VendaDeserializar> listaVenda = JsonConvert.DeserializeObject<List<VendaDeserializar>>(conteudoArquivo);

foreach (VendaDeserializar venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToShortDateString()}");
}















// List<Venda> listaVendas = new List<Venda>();
// DateTime dataAtual = DateTime.Now;
// //ISO 8601 padroniza a data entre sistemas;
// //Praticando com Json;
// Venda venda = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda venda2 = new Venda(2, "Licenças de software", 25.00M, dataAtual);

// listaVendas.Add(venda);
// listaVendas.Add(venda2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);


// Console.WriteLine(serializado);