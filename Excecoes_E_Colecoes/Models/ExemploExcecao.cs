using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes_E_Colecoes.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {


                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tratou excecao: " + ex.Message);
            }
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");

            //ao chegar aqui no throw ele joga a exceção pra cima procurando por alguem que possa tratar.
        }
    }
}