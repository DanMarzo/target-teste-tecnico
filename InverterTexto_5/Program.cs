Console.WriteLine("Digite um texto para inverter:");
var entrada = Console.ReadLine();

if (string.IsNullOrEmpty(entrada))
{
    Console.WriteLine("Nenhum texto fornecido.");
    return;
}
var textoInvertido = string.Empty;

var qtdeCaracteres = entrada.Count();

for (int i = 1; i <= qtdeCaracteres; i++)
{
    textoInvertido += entrada[qtdeCaracteres - i];
}
Console.WriteLine(textoInvertido);