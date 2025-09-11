namespace ConsoleApp.Design_Patterns.Composite
{
    class File : IFileSystemItem
    {
        private int size;
        private string name;

        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public int GetSize()
        {
            return size;
        }

        public void Delete()
        {
            Console.WriteLine($"Deleting file: {name}");
        }

        public void PrintStructure(string indent)
        {
            Console.WriteLine($"{indent}File Name: {name} ({size} KB)");
        }
    }
}
