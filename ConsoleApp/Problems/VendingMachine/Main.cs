using ConsoleApp.Problems.VendingMachine.Enum;
using ConsoleApp.Problems.VendingMachine.Models;

namespace ConsoleApp.Problems.VendingMachine
{
    public class Main
    {
        public static void main()
        {
            VendingMachine vendingMachine = VendingMachine.GetInstance();

            Item item1 = new("Apple Juice", "123", 10);
            Item item2 = new("Mango Juice", "234", 20);
            vendingMachine.AddItem(item1, 10);
            vendingMachine.AddItem(item2, 2);

            Console.WriteLine($"Selecting {item1.GetName()}");
            vendingMachine.SelectItem(item1.GetCode());
            vendingMachine.InsertCoin(Coin.QUARTER);
            vendingMachine.DispenseItem();

            vendingMachine.SelectItem(item2.GetCode());
            vendingMachine.InsertCoin(Coin.QUARTER);
            vendingMachine.DispenseItem();

            vendingMachine.SelectItem(item2.GetCode());
            vendingMachine.InsertCoin(Coin.QUARTER);
            vendingMachine.DispenseItem();

            vendingMachine.SelectItem(item2.GetCode());
            vendingMachine.InsertCoin(Coin.DIME);
        }
    }
}