namespace FibonacciApp;

public class Fibonacci
{
    public Fibonacci(int numero)
    {
        this.Numero = numero;
    }

    public int Numero { get; set; }

    public bool FibonacciValido() => this.RaizQuadradaPerfeita();
    private bool RaizQuadradaPerfeita()
    {
        //Calcula a base onde sera subtraido ou adicionado valores para validacao;
        int potencia = 5 * this.Numero * this.Numero;
        
        int potenciaNeg = potencia - 4;
        int potenciaPos = potencia + 4;

        int raizQuadNeg = (int)Math.Sqrt(potenciaNeg);
        int raizQuadPos = (int)Math.Sqrt(potenciaPos);

        return ((raizQuadNeg * raizQuadNeg) == potenciaNeg) || ((raizQuadPos * raizQuadPos) == potenciaPos);
    }
}
