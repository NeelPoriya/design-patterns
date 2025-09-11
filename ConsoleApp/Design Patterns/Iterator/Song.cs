namespace ConsoleApp.Design_Patterns.Iterator
{
    class Song
    {
        private readonly string _name;

        public Song(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
