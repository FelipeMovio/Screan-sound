

Banda queen = new Banda("Queen", new List<Album>());

Album albumDoQuen = new Album("A night at the opera", new List<Musica>());

Musica musica2 = new Musica("Bohemian Rhapsody", queen, 213, true);

Musica musica3 = new Musica("Love of my life", queen, 198, true);

albumDoQuen.AdicionarMusica(musica2);
albumDoQuen.AdicionarMusica(musica3);

queen.AdicionarAlbum(albumDoQuen);
queen.ExibirDiscografia();


