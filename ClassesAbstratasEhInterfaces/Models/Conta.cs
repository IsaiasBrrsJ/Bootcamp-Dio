using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasEhInterfaces.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo {saldo:C}");
        }

        public abstract void CreditarSaldo(decimal valor);
    }
}