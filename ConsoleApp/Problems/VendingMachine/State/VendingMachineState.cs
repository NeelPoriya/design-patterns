using ConsoleApp.Problems.VendingMachine.Enum;

namespace ConsoleApp.Problems.VendingMachine.State
{
    public abstract class VendingMachineState
    {
        public VendingMachine vendingMachine;

        public VendingMachineState(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public abstract void SelectItem(string itemId);

        public abstract void Dispense();

        public abstract void InsertCoin(Coin coin);

        public abstract void Refund();
    }
}