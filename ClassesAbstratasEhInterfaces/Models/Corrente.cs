using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasEhInterfaces.Models
{
    public class Corrente : Conta
    {
        public override void CreditarSaldo(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor Inválido");
            }
        }
    }
}