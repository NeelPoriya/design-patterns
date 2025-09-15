using ConsoleApp.Problems.VendingMachine.Enum;

namespace ConsoleApp.Problems.VendingMachine.State
{
    public class DispensingState : VendingMachineState
    {
        public DispensingState(VendingMachine vendingMachine) : base(vendingMachine)
        {
        }

        public override void Dispense()
        {
            Console.WriteLine("Dispensing in progress");
        }

        public override void InsertCoin(Coin coin)
        {
            Console.WriteLine("Cannot insert coins");
        }

        public override void Refund()
        {
            Console.WriteLine("Cannot refund, dispensing in progress");
        }

        public override void SelectItem(string itemId)
        {
            Console.WriteLine("Cannot select item, dispensing in progress");
        }
    }
}