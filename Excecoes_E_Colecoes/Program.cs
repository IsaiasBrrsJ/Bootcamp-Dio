using Excecoes_E_Colecoes.Models;

Console.Clear();

//DICTIONARY

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RO", "Rôndonia");
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]); // <== Consultar valor pela chave

foreach (KeyValuePair<string, string> estado in estados)
{
    Console.WriteLine(estado.Key + " " + estado.Value);
}

estados.Remove("BA");
estados["SP"] = "Sâo Paulo - valor alterado"; //Alterar em um dictionary

Console.WriteLine("-----------");
foreach (KeyValuePair<string, string> estado in estados)
{
    Console.WriteLine(estado.Key + " " + estado.Value);
}









//PILHA STACK<>
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


// System.Console.WriteLine("Removendo o elemento do topo: " + pilha.Pop());
// pilha.Push(20);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }















//Queue First in First out
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("Removendo o elemento: " + fila.Dequeue());
// fila.Enqueue(10);
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// new ExemploExcecao().Metodo1();



//Tratamento de exceções
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }


