namespace ConsoleApp.Design_Patterns.Adapter
{
    interface IPaymentProcessor
    {
        void ProcessPayment(double amount, string currency);
        bool IsPaymentSuccessful();
        string GetTransactionId();
    }
}
