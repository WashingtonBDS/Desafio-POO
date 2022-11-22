using System.Text;
using DesafioDeProjeto.Models;

Console.OutputEncoding = Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

try
{
    Suite suite = new Suite(tipoSuite: "premium", capacidade: 2, valorDiaria: 30);

    
    Reserva = reserva = new Reserva(DiasReservados = );
    Reserva.CadastrarSuite(suite);
    Reserva.CadastrarHospedes(hospedes);

    
    Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor da dairia: {resverva.CalcularValorDiaria()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
    Console.ReadKey();

