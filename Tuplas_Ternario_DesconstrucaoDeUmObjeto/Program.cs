
using Tuplas_Ternario_DesconstrucaoDeUmObjeto.Models;

//Praticando com tuplas e descontrutor
Console.Clear();
PraticandoDescontrutorETupla praticando = new PraticandoDescontrutorETupla(nome: "Teste", idade: 22);

//separando os paramentros do construtor em variaveis abaixo;
(string nome, int idade) = praticando;

Console.WriteLine(nome + " " + idade);
//

var (Nome, Idade) = praticando.TuplasTeste();


Console.WriteLine("--------------\nTUPLA");
Console.WriteLine(Nome + " " + Idade);






//IF ternário

// int numero = 20;
// // if (numero % 2 == 0)
// // {
// //     Console.WriteLine($"O número: {numero} é par");
// // }
// // else
// // {
// //     Console.WriteLine($"O número: {numero} é ímpar");
// // }

// var imparOuPar = numero % 2 == 0 ? $"O número: {numero} é par" : $"O número: {numero} é Ímpar";
// Console.WriteLine(imparOuPar);



//Descontrutor

// Pessoa p1 = new Pessoa("teste", "TesteUm");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// //descartar uma informação da tupla usa um  '_';

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);

//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }




//Tuplas
//(int Id, string Nome, string Sobrenome, decimal Valor) tupla = (1, "Teste", "testeDois", 10.32M);
// maneria recomendada pela legibilidade;

// Console.WriteLine("ID: " + tupla.Item1);
// Console.WriteLine("Nome: " + tupla.Item2);
// Console.WriteLine("Sobrenome: " + tupla.Item3);
// Console.WriteLine("Valor: " + tupla.Item4);

// Fim Tuplas
//Outra forma de representar TUPLA
// ValueTuple<int, string, string, decimal> outroExemplo = (1, "RR", "Soares", 22.31M);


// Console.WriteLine("ID: " + outroExemplo.Item1);
// Console.WriteLine("Nome: " + outroExemplo.Item2);
// Console.WriteLine("Sobrenome: " + outroExemplo.Item3);
// Console.WriteLine("Valor: " + outroExemplo.Item4);
