namespace ConsoleApp.OOPS.Abstraction
{
    public class Main
    {
        public static void main()
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.Pay(500);

            UPIPayment upiPayment = new UPIPayment();
            upiPayment.Pay(1000);
        }
    }
}
