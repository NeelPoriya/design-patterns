using ConsoleApp.Problems.VendingMachine.Enum;

namespace ConsoleApp.Problems.VendingMachine.State
{
    public class ItemSelectedState : VendingMachineState
    {
        public ItemSelectedState(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }

        public override void Dispense()
        {
            Console.WriteLine("Cannot dispense item");
        }

        public override void InsertCoin(Coin coin)
        {
            vendingMachine.AddBalance((int)coin);
            int? requiredBalance = vendingMachine.GetSelectedItem()?.GetPrice();

            if (!requiredBalance.HasValue)
            {
                Console.WriteLine("Item not found");
                return;
            }
            if (vendingMachine.GetBalance() >= requiredBalance.Value)
            {
                Console.WriteLine("Required amount of coins received");
                vendingMachine.SetState(new HasMoneyState(vendingMachine));
            }
        }

        public override void Refund()
        {
            vendingMachine.RefundBalance();
            vendingMachine.Reset();
        }

        public override void SelectItem(string itemId)
        {
            Console.WriteLine("Item already selected");
        }
    }
}