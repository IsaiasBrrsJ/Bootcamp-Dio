using ClassesAbstratasEhInterfaces.Interfaces;
using ClassesAbstratasEhInterfaces.Models;


// Computador c = new Computador();
// Console.WriteLine(c.ToString());
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 2));

#region polimorfismo heranca sealed
// Pessoa p1 = new Pessoa("testePessoa");
// Aluno a1 = new Aluno("testeAluno");

// p1.Apresentar();
// a1.Apresentar();
#endregion


#region Classe Abstrata

// Conta c = new Corrente();

// c.CreditarSaldo(200);
// c.ExibirSaldo();

#endregion