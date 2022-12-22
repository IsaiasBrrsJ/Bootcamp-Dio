using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticandoTrilhasDesafioSolo.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.CapacidadeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Suite não suporta essa capacidade de hóspedes");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //Dias reservados x valor da diária

            decimal diaria = (DiasReservados * Suite.ValorDiaria);

            if (DiasReservados >= 10)
            {
                diaria -= (diaria * 0.10M);
            }


            return diaria;
        }
    }
}