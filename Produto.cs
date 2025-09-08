public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public Produto(int id, string nome, int quantidade)
    {
        Id = id;
        Nome = nome;
        Quantidade = quantidade;
    }

    public void Entrada(int qtd)
    {
        Quantidade += qtd;
    }

    public void Saida(int qtd)
    {
        if (qtd <= Quantidade)
            Quantidade -= qtd;
        else
            Console.WriteLine("Quantidade insuficiente em estoque!");
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Quantidade: {Quantidade}";
    }
}
