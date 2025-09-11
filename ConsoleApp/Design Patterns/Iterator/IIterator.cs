namespace ConsoleApp.Design_Patterns.Iterator
{
    interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
