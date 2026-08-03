class Musica
{
    public String nome{ get; set; }
    public String artista{ get; set; }
    public int duracao{ get; set; }
    public bool disponivel { get; set; }


    public void exibirFichaTecnica()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Artista: " + artista);
        Console.WriteLine("Duração: " + duracao + " segundos");
        if (disponivel){
            Console.WriteLine("Disponível: Sim");
        }
        else {
            Console.WriteLine("Disponível: Não");
        }
    }


}