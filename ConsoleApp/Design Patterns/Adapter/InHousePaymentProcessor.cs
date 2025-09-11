namespace ConsoleApp.Design_Patterns.Adapter
{
    class InHousePaymentProcessor : IPaymentProcessor
    {
        private string transactionId = "";
        private bool isPaymentSuccessfulFlag;

        public InHousePaymentProcessor()
        {
            isPaymentSuccessfulFlag = false;
        }

        public void ProcessPayment(double amount, string currency)
        {
            Console.WriteLine($"{nameof(InHousePaymentProcessor)} Processing payment of {amount} {currency}");
            transactionId = "TXN_" + DateTimeOffset.Now.ToUnixTimeMilliseconds();
            isPaymentSuccessfulFlag = true;
            Console.WriteLine($"{nameof(InHousePaymentProcessor)} Payment successful. Txn ID: {transactionId}");
        }

        public bool IsPaymentSuccessful()
        {
            return isPaymentSuccessfulFlag;
        }

        public string GetTransactionId()
        {
            return transactionId;
        }
    }
}
