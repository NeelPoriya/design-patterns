using ConsoleApp.Problems.VendingMachine.Enum;
using ConsoleApp.Problems.VendingMachine.Models;

namespace ConsoleApp.Problems.VendingMachine.State
{
    public class IdleState : VendingMachineState
    {
        public IdleState(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }

        public override void Dispense()
        {
            Console.WriteLine($"No item selected. Kindly select an item.");
        }

        public override void InsertCoin(Coin coin)
        {
            Console.WriteLine("Please select an item before inserting coins");
        }

        public override void Refund()
        {
            Console.WriteLine("No item selected");
        }

        public override void SelectItem(string itemId)
        {
            if (!vendingMachine.GetInventory().IsAvailable(itemId))
            {
                Console.WriteLine("Item not available!");
                return;
            }
            vendingMachine.SetSelectedItemCode(itemId);
            vendingMachine.SetState(new ItemSelectedState(vendingMachine));
            Console.WriteLine($"Item selected: {itemId}");
        }
    }
}