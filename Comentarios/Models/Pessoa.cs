using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comentarios.Models
{
    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }


        /// <summary>
        /// Faz a pessoa se apresentar
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine("Apresentar-se");
        }

        #region  Summary Metodo Somar
        /// <summary>
        /// Realizar a soma de dois números
        /// </summary>
        /// <param name="x">Primeiro número inteiro para somar</param>
        /// <param name="y">Segundo número inteiro para somar</param>

        #endregion
        public void Somar(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }

}