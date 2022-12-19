int quantidadeEmEstoque = 10;
int quantidadeCompra = 3;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Qunatidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade em Compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (quantidadeCompra <= quantidadeEmEstoque)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
}

