using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Métodos_e_Construtores_com_C_.Models
{
    /// <summary>
    /// Classe que retornar nome e idade de um pessoa
    /// </summary>
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();
            set
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
            set
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