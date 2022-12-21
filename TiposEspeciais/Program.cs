using TiposEspeciais.Models;

//Tipo Dinamico

// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");



MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdcionarElementosArray(30);

int numero = 14;
var par = numero.EhPar();



Console.WriteLine(arrayInteiro[0]);






//Tipo Anonimo

// var tipoAnonimo = new { Nome = "Teste", Sobrenome = "T", Altura = 1.90 };

// Console.WriteLine(tipoAnonimo.Nome);
// Console.WriteLine(tipoAnonimo.Sobrenome);
// Console.WriteLine(tipoAnonimo.Altura);

//Tipo anonimo somente leitura não pode retornar em metodos











// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }