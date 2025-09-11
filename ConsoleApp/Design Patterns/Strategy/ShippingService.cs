namespace ConsoleApp.Design_Patterns.Strategy
{
    class ShippingService
    {
        private IShippingStrategy strategy;

        public ShippingService(IShippingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IShippingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double CalculateShippingCost(Order order)
        {
            if (strategy == null)
            {
                throw new InvalidOperationException("Shipping strategy is not set.");
            }
            return strategy.CalculateCost(order);
        }
    }
}
