namespace ConsoleApp.Design_Patterns.Strategy
{
    class WeightBasedShippingStrategy : IShippingStrategy
    {
        public double CalculateCost(Order order)
        {
            return order.Weight * 5.0;
        }
    }
}
