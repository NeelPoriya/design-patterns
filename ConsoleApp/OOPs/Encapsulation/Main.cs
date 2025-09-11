namespace ConsoleApp.OOPS.Encapsulation
{
    public class Main
    {
        public static void main()
        {
            BankAccount bankAccount = new BankAccount(initialBalance: 1000);

            bankAccount.WithDraw(500);
            bankAccount.Credit(1000);

            Console.WriteLine(bankAccount.Balance);
        }
    }
}
