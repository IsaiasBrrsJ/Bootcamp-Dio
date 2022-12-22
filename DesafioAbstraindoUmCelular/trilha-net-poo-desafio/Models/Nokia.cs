namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{nomeApp} Instalado com sucesso");
            Console.ResetColor();
        }
    }
}