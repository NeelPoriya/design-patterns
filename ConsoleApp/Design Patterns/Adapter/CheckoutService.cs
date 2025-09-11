namespace ConsoleApp.Design_Patterns.Adapter
{
    class CheckoutService
    {
        private IPaymentProcessor paymentProcessor;

        public CheckoutService(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;
        }

        public void Checkout(double amount, string currency)
        {
            Console.WriteLine($"Checkout Service: Attempting to process order for {amount} {currency}");
            paymentProcessor.ProcessPayment(amount, currency);
            if (paymentProcessor.IsPaymentSuccessful())
            {
                Console.WriteLine($"Checkout Service: Order successful! Transaction ID: {paymentProcessor.GetTransactionId()}");
            }
            else
            {
                Console.WriteLine($"Checkout Service: Order failed. Payment was not successful.");
            }
        }
    }
}
