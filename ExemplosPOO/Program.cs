using ExemplosPOO.Models;


#region  Etapa 2 POO HERANCA POLIMORFISMO

Aluno a1 = new Aluno();
a1.Nome = "teste";
a1.Idade = 1;
a1.Email = "teste@gmail.com";
a1.Nota = 7.5;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Teacher";
p1.Idade = 43;
p1.Salario = 1000;
p1.Apresentar();
#endregion



#region  Etapa 1 POO ENCAPSULAMENTO 
// Pessoa p1 = new Pessoa();

// p1.Idade = 2;
// p1.Nome = "teste";

// p1.Apresentar();

// ContaCorrente c1 = new ContaCorrente(123, 1000);


// c1.ExibirSaldo();
// c1.Sacar(3000);
// c1.ExibirSaldo();




#endregion