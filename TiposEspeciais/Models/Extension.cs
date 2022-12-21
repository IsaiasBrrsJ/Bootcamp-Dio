using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposEspeciais.Models
{
    public static class Extension
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}