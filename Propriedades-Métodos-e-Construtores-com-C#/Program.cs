using Propriedades_Métodos_e_Construtores_com_C_.Models;
using System.Collections.Generic;

Pessoa p1 = new Pessoa(nome: "Teste", sobrenome: "TesteeDois");

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves queiroz");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";

cursoDeIngles.AdcionarAluno(p1);
cursoDeIngles.AdcionarAluno(p2);
cursoDeIngles.ListarAluno();



// Pessoa p1 = new Pessoa();
// p1.Nome = "teste";
// p1.Sobrenome = "TesteDois";
// p1.Idade = 2;
// p1.Apresentar();
