using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;


        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {

                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado maior que valor disponivel");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é: {saldo:C}");
        }



    }
}