namespace ConsoleApp.Design_Patterns.Adapter
{
    class LegacyGatewayAdapter : IPaymentProcessor
    {
        private LegacyGateway legacyGateway;

        public LegacyGatewayAdapter(LegacyGateway legacyGateway)
        {
            this.legacyGateway = legacyGateway;
        }

        public string GetTransactionId()
        {
            return "LEGACY_TXN_" + legacyGateway.GetReferenceNumber();
        }

        public bool IsPaymentSuccessful()
        {
            long referenceNumber = legacyGateway.GetReferenceNumber();
            return legacyGateway.CheckStatus(referenceNumber);
        }

        public void ProcessPayment(double amount, string currency)
        {
            Console.WriteLine($"Adapting process payment for Legacy system");
            legacyGateway.ExecuteTransaction(amount, currency);
        }
    }
}
