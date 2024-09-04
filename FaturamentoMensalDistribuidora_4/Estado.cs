namespace FaturamentoMensalDistribuidora_4;

public class Estado
{
    public Estado(string nome, decimal valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public string Nome { get; set; }
    public decimal Valor { get; set; }

    public decimal CalculaPorcentagem(decimal total)
    {
        return this.Valor * 100 / total;
    }
}
