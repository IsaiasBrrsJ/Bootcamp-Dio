

//laço for
// int numero = 10;
// //Console.WriteLine($"{numero} x 1 = {numero  * 1}");

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($" 10 * {i}  = {i * 10} ");
// }

//LAÇO WHILE

// int numero = 5;
// int contador = 1;
// while (contador <= 10)
// {
//     System.Console.WriteLine($"{numero} * {contador} = {numero * contador}");

//     if (contador == 6)
//     {
//         break;
//     }
//     contador++;
// }

//Laco do while
// int soma = 0, numero = 0;
// do
// {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine("Total da soma dos números digitados é: " + soma);

//MENU interativo

string opcao;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();

    Console.WriteLine("Digite a sua opção: ");

    Console.WriteLine("1- Cadstrar Cliente");
    Console.WriteLine("2- Buscar Cliente");
    Console.WriteLine("3- Apagar Cliente");
    Console.WriteLine("4- Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

Console.WriteLine("O programa se encerrou");