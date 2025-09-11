using System.Text.Json;

namespace ConsoleApp.Design_Patterns.Strategy
{
    class Main
    {
        public static void main()
        {
            Order order = new Order(20, "Zone A");

            FlatShippingStrategy strategy1 = new FlatShippingStrategy();
            ShippingService shippingService = new ShippingService(strategy1);

            double price1 = shippingService.CalculateShippingCost(order);

            Console.WriteLine($"Flat Shipping cost for order: {JsonSerializer.Serialize(order)} is {price1}");

            WeightBasedShippingStrategy strategy2 = new WeightBasedShippingStrategy();
            shippingService.SetStrategy(strategy2);

            double price2 = shippingService.CalculateShippingCost(order);

            Console.WriteLine($"Weight based shipping cost for order: {JsonSerializer.Serialize(order)} is {price2}");

            DistanceBasedShippingStrategy strategy3 = new DistanceBasedShippingStrategy();
            shippingService.SetStrategy(strategy3);

            double price3 = shippingService.CalculateShippingCost(order);
            Console.WriteLine($"Distance based shipping code for order: {JsonSerializer.Serialize(order)} is {price3}");
        }
    }
}
