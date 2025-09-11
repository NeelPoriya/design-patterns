namespace ConsoleApp.Design_Patterns.Iterator
{
    class Main
    {
        public static void main()
        {
            Playlist playlist = new Playlist();

            Song song1 = new Song("Shape of You");
            Song song2 = new Song("Cake by the Ocean");
            Song song3 = new Song("Arcade");

            playlist.AddSong(song1);
            playlist.AddSong(song2);
            playlist.AddSong(song3);

            IIterator<Song> iterator = playlist.CreateIterator();

            while (iterator.HasNext())
            {
                Song song = iterator.Next();
                Console.WriteLine($"🎶 Playing: {song.GetName()}");
            }
        }
    }
}
