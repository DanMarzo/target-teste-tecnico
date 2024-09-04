using FibonacciApp;

Console.WriteLine("Digite um número:");
var numEntrada = Console.ReadLine();

try
{

    if (int.TryParse(numEntrada, out int numeroValido))
    {
        var fibonacci = new Fibonacci(numeroValido);

        var mensagem = fibonacci.FibonacciValido()
            ? $"Número {fibonacci.Numero} pertence."
            : $"Número {fibonacci.Numero} não pertence.";
        Console.WriteLine(mensagem);
        return;
    }
    Console.WriteLine($"Valor {numEntrada} não é um numero.");
    return;
}
catch (Exception ex) 
{
    Console.WriteLine($"Erro inesperado.");
    Console.WriteLine(ex.Message);
    return;
}
