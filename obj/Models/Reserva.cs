using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeProjeto
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("O numero de hospedes é superior a capacidade da Suite."); 
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

            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor -= (valor * 10 / 100);
            }

            return valor;
        }
    }

}