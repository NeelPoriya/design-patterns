using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using ConsoleApp.Problems.VendingMachine.Enum;
using ConsoleApp.Problems.VendingMachine.Models;
using ConsoleApp.Problems.VendingMachine.State;

namespace ConsoleApp.Problems.VendingMachine
{
    public class VendingMachine
    {
        private static VendingMachine? instance;
        private string selectedItemCode = "";
        private Inventory inventory = new Inventory();
        private static readonly object lockObj = new object();
        private VendingMachineState state;
        private int balance = 0;

        public VendingMachine()
        {
            state = new IdleState(this);
        }
        public static VendingMachine GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new VendingMachine();
                    }
                }
            }
            return instance;
        }

        public void AddBalance(int value)
        {
            balance += value;
        }

        public int GetBalance() => balance;

        public Item? GetItem(string itemId)
        {
            return inventory.GetItem(itemId);
        }

        public void SetSelectedItemCode(string itemId)
        {
            this.selectedItemCode = itemId;
        }

        public Item? GetSelectedItem()
        {
            return inventory.GetItem(selectedItemCode);
        }

        public Inventory GetInventory() => inventory;

        public void SetState(VendingMachineState state)
        {
            this.state = state;
        }

        public void RefundBalance()
        {
            Console.WriteLine($"Refunding {balance}");
        }

        public void Reset()
        {
            balance = 0;
            SetSelectedItemCode("");
        }

        public void DispenseItem()
        {
            Item? item = inventory.GetItem(selectedItemCode);
            if (item != null && balance >= item.GetPrice())
            {
                balance -= item.GetPrice();
                RefundBalance();
                inventory.ReduceStock(item.GetCode());
                Console.WriteLine($"Dispensed Item: {item}");
            }
            Reset();
            SetState(new IdleState(this));
        }

        public void AddItem(Item item, int quantity)
        {
            inventory.AddItem(item.GetCode(), item, quantity);
        }

        public void SelectItem(string id)
        {
            state.SelectItem(id);
        }

        public void InsertCoin(Coin coin)
        {
            state.InsertCoin(coin);
        }
    }
}