using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasEhInterfaces.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}