using CriandoClasses.Models;

string apresetacao = "Olá, seja bem-vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresetacao);
Console.WriteLine("Valor da variável quantidade " + quantidade);
Console.WriteLine("Valor da variável altura " + altura);
Console.WriteLine("Valor da variável preco " + preco);



Pessoa p = new Pessoa();

p.Nome = "Testando classe pessoa";
p.Idade = 233;

p.Apresentar();
