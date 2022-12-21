using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetSerializarEhAtributos.Models
{
    public class Curso
    {

        public Curso()
        {
            Alunos = new List<Pessoa>();
        }
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }


        public void AdcionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {

            Console.WriteLine($"Alunos do curos de: {Nome}"); //Interpolação de string $
            for (int count = 0; count < Alunos.Count; count++)
            {
                //string text = "Nº " + (count + 1) + " - " + Alunos[count].NomeCompleto; //Concatenação de string
                string text = $"Nº {count + 1} - {Alunos[count].NomeCompleto}"; //Interporlação
                Console.WriteLine(text);
            }

        }
    }
}
