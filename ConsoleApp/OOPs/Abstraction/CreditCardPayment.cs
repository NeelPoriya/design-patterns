namespace ConsoleApp.OOPS.Abstraction
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment() { }

        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using credit card");
        }
    }
}
