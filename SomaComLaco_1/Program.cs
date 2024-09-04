int indice = 13, soma = 0, k = 0;

while (k < indice)
{
    soma += k;
    k += 1;
}

Console.WriteLine($"""
    Soma total {soma}
    Valor K = {k}
    """);
