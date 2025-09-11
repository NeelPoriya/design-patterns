namespace ConsoleApp.Design_Patterns.Strategy
{
    public class Order
    {
        public string DestinationZone { get; private set; } = "";
        public double Weight { get; private set; }

        public Order(double weight, string destinationZone)
        {
            Weight = weight;
            DestinationZone = destinationZone;
        }
    }
}