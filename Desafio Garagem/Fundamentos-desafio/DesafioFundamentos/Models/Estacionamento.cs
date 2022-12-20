namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();

            veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");


            string placa = Console.ReadLine();


            //Verifica se o veiculo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                int horas = 0;
                //Enquanto digita valor inválido fica aqui
                do
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                }
                while (int.TryParse(Console.ReadLine(), out horas) is false);


                decimal valorTotal = (precoInicial + (precoPorHora * horas));

                veiculos.Remove(placa);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.ResetColor();
            }
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
