namespace ConsoleApp.Design_Patterns.Adapter
{
    class Main
    {
        public static void main()
        {
            Console.WriteLine("---Existing Checkout---");
            IPaymentProcessor paymentProcessor = new InHousePaymentProcessor();
            CheckoutService checkoutService = new CheckoutService(paymentProcessor);
            checkoutService.Checkout(255.90, "USD");

            Console.WriteLine("\n\n---Legacy Checkout---");
            LegacyGateway legacyGateway = new LegacyGateway();
            IPaymentProcessor legacyGatewayProcessor = new LegacyGatewayAdapter(legacyGateway);
            checkoutService = new CheckoutService(legacyGatewayProcessor);
            checkoutService.Checkout(255.90, "USD");
        }
    }
}
