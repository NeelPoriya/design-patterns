namespace ConsoleApp.Design_Patterns.Strategy
{
    interface IShippingStrategy
    {
        double CalculateCost(Order order);
    }
}
