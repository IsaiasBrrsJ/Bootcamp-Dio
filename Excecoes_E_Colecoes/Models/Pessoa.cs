using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes_E_Colecoes.Models
{
    /// <summary>
    /// Classe que retornar nome e idade de um pessoa
    /// </summary>
    public class Pessoa
    {

        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto { get => Nome + " " + Sobrenome; }


        public int Idade
        {
            get => _idade;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade incorreta");
                }

                _idade = value
                ++;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto.ToUpper()}, Idade: {Idade}");
        }
    }
}