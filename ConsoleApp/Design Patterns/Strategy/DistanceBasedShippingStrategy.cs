namespace ConsoleApp.Design_Patterns.Strategy
{
    class DistanceBasedShippingStrategy : IShippingStrategy
    {
        public double CalculateCost(Order order)
        {
            if (order.DestinationZone == "Zone A")
            {
                return 5;
            }
            else if (order.DestinationZone == "Zone B")
            {
                return 10;
            }

            return 15;
        }
    }
}
