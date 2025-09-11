namespace ConsoleApp.Design_Patterns.Composite
{
    interface IFileSystemItem
    {
        int GetSize();
        void PrintStructure(string indent);
        void Delete();
    }
}
