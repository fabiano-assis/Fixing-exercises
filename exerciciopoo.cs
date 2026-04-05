Retangulo r = new Retangulo(7,4);
Circulo c = new Circulo(5);

r.ExibirArea();
Console.WriteLine();
c.ExibirArea();

class Forma
{
    public virtual double CalcularArea()
    {
        return 0;
    }
}


class Retangulo : Forma
{
    private double Largura;
    private double Altura;

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }

    public void ExibirArea()
    {
        Console.WriteLine($"Retângulo {Largura}x{Altura}");
        Console.WriteLine($"Área: {CalcularArea()}");
    }
}


class Circulo : Forma
{
    private double Raio;

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }

    public void ExibirArea()
    {
        Console.WriteLine($"Círculo de raio {Raio}");
        Console.WriteLine($"Área: {CalcularArea()}");
    }
}

Área: 50,265482457436690
