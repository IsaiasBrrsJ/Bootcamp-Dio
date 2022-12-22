namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
      : base(numero, modelo, imei, memoria) { }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nomeApp} Instalado com sucesso");
            Console.ResetColor();
        }
    }
}