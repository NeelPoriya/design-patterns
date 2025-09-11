namespace ConsoleApp.Design_Patterns.Iterator
{
    class PlaylistIterator : IIterator<Song>
    {
        private readonly Playlist playlist;
        private int index = 0;
        public PlaylistIterator(Playlist playlist)
        {
            this.playlist = playlist;
            this.index = playlist.GetSize() - 1;
        }

        public bool HasNext()
        {
            return index >= 0;
        }

        public Song Next()
        {
            return playlist.GetSongAtIndex(index--);
        }
    }
}
