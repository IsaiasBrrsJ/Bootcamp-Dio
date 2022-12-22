using PraticandoTrilhasDesafioSolo.Models;

List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa("hóspede", "1");
Pessoa p2 = new Pessoa("hóspede", "2");
Pessoa p3 = new Pessoa("hóspede", "3");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(new Suite { TipoSuite = "Premium", CapacidadeHospedes = 3, ValorDiaria = 30 });
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("Quantidade de hóspedes: " + reserva.ObterQuantidadeDeHospedes());
Console.WriteLine("Valor total da diária:" + reserva.CalcularValorDiaria().ToString("C"));