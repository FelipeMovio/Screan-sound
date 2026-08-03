class Musica
{
    public String Nome{ get; set; }
    public String Artista{ get; set; }
    public int Duracao{ get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida =>
          $"A musica {Nome} do artista {Artista}";


    public void exibirFichaTecnica()
    {
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