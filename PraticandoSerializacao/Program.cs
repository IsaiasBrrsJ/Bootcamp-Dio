using PraticandoSerializacao.Models;
using Newtonsoft.Json;

List<Clieente> clientes = new List<Clieente>();
Clieente clienteI = new Clieente(1, "Barros", new Produto { Id = 1, Nome = "Chave Windows 10", Preco = 33.4M });

clientes.Add(clienteI);

var serializar = JsonConvert.SerializeObject(clientes, Formatting.Indented);

System.Console.WriteLine(serializar);
File.WriteAllText("ArquivosJson/arq.json", serializar);

//Deserializar objeto
List<Deserializar> listaCliente = JsonConvert.DeserializeObject<List<Deserializar>>(serializar);

foreach (var ss in listaCliente)
{
    Console.WriteLine("Id: " + ss.Id);
    Console.WriteLine("Nome: " + ss.Nome);
    Console.WriteLine("-----------\nProdutos");
    Console.WriteLine("Id: " + ss.Produtos.Id);
    Console.WriteLine("Nome:" + ss.Produtos.Nome);
    Console.WriteLine("Preço: " + ss.Produtos.Preco);
}