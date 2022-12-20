int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

Console.WriteLine("Percorrendo array com FOR");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição Nº {i}: " + arrayInteiros[i]);
}


Console.WriteLine("Percorrendo array com FOREACH");
foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}

//Redimensionando um ARRAY

// Array.Resize(ref arrayInteiros, arrayInteiros.Length + 1);

//Copiando Array;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

