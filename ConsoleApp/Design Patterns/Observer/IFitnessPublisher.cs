namespace ConsoleApp.Design_Patterns.Observer
{
    interface IFitnessPublisher
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObserver();
    }
}
