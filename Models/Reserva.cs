using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio_hotelaria.Models
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

        public void CadastrarHospedes(List<Pessoa> hospede)
        {   
            bool capacidaValida = false;

            capacidaValida = Suite.Capacidade >= hospede.Count;

            if(capacidaValida)
                {
                    Hospedes = hospede;
                } 
            else
                {
                throw new Exception("Capacidade menor do que a lista de hóspedes");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }


        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                return valorTotal - (valorTotal * 0.1M);
            }
            else
            {
                return valorTotal;
            }
            
        }
    }
}