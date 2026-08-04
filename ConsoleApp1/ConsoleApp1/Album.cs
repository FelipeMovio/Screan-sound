class Album
{
    private string Nome { get; set; }

    public int DuracaoTotal =>
        musicas.Sum(m => m.Duracao);

    private List<Musica> musicas = new List<Musica>();

    public Album(string nome, List<Musica> musicas)
    {
        Nome = nome;
        this.musicas = musicas;
    }


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
     
    }

    public void ExibirMusicas()
    {
        Console.WriteLine("Músicas do álbum " + Nome + ":");

        //for(int i = 0; i < musicas.Count; i++)
        //{
        //    Console.WriteLine("- " + musicas[i].Nome);
        //}

        foreach (var musica in musicas)
        {
            Console.WriteLine("- " + musica.Nome);
        }

        Console.WriteLine($"Para ouvir todas as músicas do álbum, você precisará de {DuracaoTotal} segundos.");
    }
}