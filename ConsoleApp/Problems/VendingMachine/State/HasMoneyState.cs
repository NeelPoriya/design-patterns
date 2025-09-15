using ConsoleApp.Problems.VendingMachine.Enum;

namespace ConsoleApp.Problems.VendingMachine.State
{
    public class HasMoneyState : VendingMachineState
    {
        public HasMoneyState(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }

        public override void Dispense()
        {
            Console.WriteLine("Dispensing in progress");
            vendingMachine.SetState(new DispensingState(vendingMachine));
            vendingMachine.DispenseItem();
        }

        public override void InsertCoin(Coin coin)
        {
            Console.WriteLine("Already received required amount of coins");
        }

        public override void Refund()
        {
            vendingMachine.RefundBalance();
            vendingMachine.Reset();
            vendingMachine.SetState(new IdleState(vendingMachine));
        }

        public override void SelectItem(string itemId)
        {
            Console.WriteLine("Cannot select item, dispensing in progress");
        }
    }
}