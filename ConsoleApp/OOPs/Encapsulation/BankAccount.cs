namespace ConsoleApp.OOPS.Encapsulation
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            this.balance = initialBalance;
        }

        public void WithDraw(double amount)
        {
            if (amount <= balance)
                balance = amount;
        }

        public void Credit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public double Balance => balance;
    }
}
