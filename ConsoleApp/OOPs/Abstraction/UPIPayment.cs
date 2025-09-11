namespace ConsoleApp.OOPS.Abstraction
{
    public class UPIPayment : Payment
    {
        public UPIPayment() { }

        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using UPI");
        }
    }
}
