namespace ConsoleApp.Design_Patterns.Strategy
{
    class FlatShippingStrategy : IShippingStrategy
    {
        public double CalculateCost(Order order)
        {
            return 10.0;
        }
    }
}
