namespace ConsoleApp.Design_Patterns.Composite
{
    class Folder(string name) : IFileSystemItem
    {
        private string name = name;
        private readonly IList<IFileSystemItem> children = [];

        public void PrintStructure(string indent = "")
        {
            Console.WriteLine($"{indent}Folder name: {name}");

            foreach (IFileSystemItem item in children)
            {
                item.PrintStructure(indent + " ");
            }
        }

        public void Delete()
        {
            foreach (IFileSystemItem child in children)
            {
                child.Delete();
            }
            Console.WriteLine($"Deleting Folder: {name}");
        }

        public int GetSize()
        {
            int total = 0;
            foreach (IFileSystemItem item in children)
            {
                total += item.GetSize();
            }
            return total;
        }

        public void AddItem(IFileSystemItem item)
        {
            children.Add(item);
        }
    }
}
