class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }

  

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no Plano. ");
        }
        else
        {
            Console.WriteLine("Adquira no plano Plus+");
        }
    }
}