class Musica
{
    private string Nome { get; set; }
    private Banda Artista { get; }
    public int Duracao { get; set; }
    private bool Disponivel { get; set; }

    public Genero Genero { get; set; }

    public string DescricaoResumida =>
          $"A musica {Nome} do artista {Artista}";


    public Musica(string nome, Banda artista, int duracao, bool disponivel)
    {
        Nome = nome;
        Artista = artista;
        Duracao = duracao;
        Disponivel = disponivel;
    }


    public void exibirFichaTecnica()
    {
        Console.WriteLine($"Genero: {Genero.Nome}");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Artista: " + Artista);
        Console.WriteLine("Duração: " + Duracao + " segundos");
        if (Disponivel){
            Console.WriteLine("Disponível: Sim");
        }
        else {
            Console.WriteLine("Disponível: Não");
        }
    }



}