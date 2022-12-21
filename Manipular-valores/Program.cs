using ManipularValores.Models;
using System.Globalization;

// //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
// decimal valorMonetario = 1582.40M;


// // Console.WriteLine($"{valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

// //Console.WriteLine($"{valorMonetario.ToString("C2")}");


// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));



//FORMATANDO DATETIME
string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact
(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine("Conversão com sucesso");
    Console.WriteLine(data);
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}














// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

// Pessoa p1 = new Pessoa(nome: "Teste", sobrenome: "TesteeDois");

// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves queiroz");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";

// cursoDeIngles.AdcionarAluno(p1);
// cursoDeIngles.AdcionarAluno(p2);
// cursoDeIngles.ListarAluno();



// Pessoa p1 = new Pessoa();
// p1.Nome = "teste";
// p1.Sobrenome = "TesteDois";
// p1.Idade = 2;
// p1.Apresentar();