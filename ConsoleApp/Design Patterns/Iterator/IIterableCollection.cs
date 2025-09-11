namespace ConsoleApp.Design_Patterns.Iterator
{
    interface IIterableCollection<T>
    {
        IIterator<T> CreateIterator();
    }
}
