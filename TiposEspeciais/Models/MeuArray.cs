using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposEspeciais.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdcionarElementosArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
            }

            contador++;
        }

        public T this[int Index]
        {
            get { return array[Index]; }
            set { array[Index] = value; }
        }

    }
}