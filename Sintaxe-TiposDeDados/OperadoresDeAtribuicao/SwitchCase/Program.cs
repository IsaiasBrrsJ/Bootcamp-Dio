Console.WriteLine("Digite uma letra: ");
var letra = Console.ReadLine();

switch (letra)
{
    case "A" or "a":
    case "E" or "e":
    case "I" or "i":
    case "O" or "o":
    case "U" or "u":
        Console.WriteLine("É uma vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;

}