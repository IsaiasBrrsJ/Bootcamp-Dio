bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

//operador OR ||
if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}

//Operador AND &&

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

//Operador NOT (!) Negação de um valor

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}

