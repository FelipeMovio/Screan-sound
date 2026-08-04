Musica musica1 = new Musica();
musica1.Nome = "Shape of You";
musica1.Artista = "Ed Sheeran";
musica1.Duracao = 240;
musica1.Disponivel = true;

Album albumDoQuen = new Album();
albumDoQuen.Nome = "A nigth at the opera";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Artista = "Queen";
musica2.Duracao = 213;
musica2.Disponivel = true;

Musica musica3 = new Musica();
musica3.Nome = "Love of my life";
musica3.Artista = "Queen";
musica3.Duracao = 198;
musica3.Disponivel = true;

albumDoQuen.AdicionarMusica(musica2);
albumDoQuen.AdicionarMusica(musica3);

albumDoQuen.ExibirMusicas();
