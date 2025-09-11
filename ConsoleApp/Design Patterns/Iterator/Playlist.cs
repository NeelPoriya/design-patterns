namespace ConsoleApp.Design_Patterns.Iterator
{
    class Playlist : IIterableCollection<Song>
    {
        private readonly List<Song> songs = [];

        public IIterator<Song> CreateIterator()
        {
            return new PlaylistIterator(this);
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public Song GetSongAtIndex(int index)
        {
            return songs[index];
        }

        public int GetSize()
        {
            return songs.Count;
        }
    }
}
