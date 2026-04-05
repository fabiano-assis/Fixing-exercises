Relatorio relatorio = new Relatorio("Relatório de Movimentações");
Contrato contrato = new Contrato("Contratos de Serviços");

relatorio.ExibirTitulo();
relatorio.Processar();
relatorio.Imprimir();

Console.WriteLine();

contrato.ExibirTitulo();
contrato.Processar();
contrato.Imprimir();


interface IImprimivel
{
    void Imprimir();
}


abstract class Documento
{
    public string Titulo;

    public Documento(string titulo)
    {
        Titulo = titulo;
    }

   
    public void ExibirTitulo()
    {
        Console.WriteLine($"Título: {Titulo}");
    }

    
    public abstract void Processar();
}


class Relatorio : Documento, IImprimivel
{
    public Relatorio(string titulo) : base(titulo) { }

    public override void Processar()
    {
        Console.WriteLine($"Processando relatório: {Titulo}");
    }

    public void Imprimir()
    {
        Console.WriteLine($"Imprimindo relatório: {Titulo}");
    }
}


class Contrato : Documento, IImprimivel
{
    public Contrato(string titulo) : base(titulo) { }

    public override void Processar()
    {
        Console.WriteLine($"Processando contrato: {Titulo}");
    }

    public void Imprimir()
    {
        Console.WriteLine($"Imprimindo contrato: {Titulo}");
    }
}
