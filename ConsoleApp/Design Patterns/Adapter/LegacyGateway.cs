namespace ConsoleApp.Design_Patterns.Adapter
{
    class LegacyGateway
    {
        private long transactionReference;
        private bool isPaymentSuccessfulFlag;

        public LegacyGateway()
        {
            transactionReference = 0;
            isPaymentSuccessfulFlag = false;
        }

        public void ExecuteTransaction(double amount, string currency)
        {
            Console.WriteLine($"Legacy Gateway: Executing transaction for {currency} {amount}");
            transactionReference = DateTimeOffset.Now.Ticks;
            isPaymentSuccessfulFlag = true;
            Console.WriteLine($"Legacy Gateway: Checking status for ref: {transactionReference}");
        }

        public bool CheckStatus(long transactionReference)
        {
            Console.WriteLine($"Legacy Gateway: Checking transaction status for {transactionReference}");
            return isPaymentSuccessfulFlag;
        }

        public long GetReferenceNumber()
        {
            return transactionReference;
        }
    }
}
