using FaturamentoMensalDistribuidora_4;

var listaEstados = new List<Estado>()
{
    new Estado("SP" ,67836.43M),
    new Estado("RJ" ,36678.66M),
    new Estado("MG" ,29229.88M),
    new Estado("ES" ,27165.48M),
    new Estado("Outros" ,19849.53M),
};

decimal totalFat = listaEstados.Aggregate(0M, (old, next) => old + next.Valor);

Console.WriteLine($"Soma de todos os valores {totalFat}");

foreach (var estado in listaEstados)
{
    var porcentagem = estado.CalculaPorcentagem(totalFat);
    Console.WriteLine($"Estado {estado.Nome} - valor {porcentagem:F}%");
}
