class Banda
{
    private string Nome { get; set; }

    private List<Album> albuns = new List<Album>();

    public Banda(string nome, List<Album> albuns)
    {
        Nome = nome;
        this.albuns = albuns;
    }

    public void AdicionarAlbum(Album album)
    {
        // Lógica para adicionar um álbum à banda
        albuns.Add(album);
    }   


    public void ExibirDiscografia()
    {
        Console.WriteLine("Discografia da banda " + Nome + ":");
        foreach (Album album in albuns)
        {
            Console.WriteLine("- Álbum: " + album.Nome);
            album.ExibirMusicas();
        }
    }
}