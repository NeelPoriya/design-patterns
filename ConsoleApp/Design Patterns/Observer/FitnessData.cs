namespace ConsoleApp.Design_Patterns.Observer
{
    class FitnessData : IFitnessPublisher
    {
        public int data { get; private set; }
        public  string data2 { get; private set; }
        private List<IObserver> observers = [];

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public FitnessData(int data, string data2)
        {
            this.data = data;
            this.data2 = data2;
        }

        public void UpdateFitnessData(int data, string data2)
        {
            this.data = data;
            this.data2 = data2;

            NotifyObserver();
        }
    }
}
