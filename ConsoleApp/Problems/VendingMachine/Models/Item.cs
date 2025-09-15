namespace ConsoleApp.Problems.VendingMachine.Models
{
    public class Item
    {
        private string name;
        private int price;
        private string code;

        public Item(string name, string code, int price)
        {
            this.name = name;
            this.code = code;
            this.price = price;
        }

        public string GetName() => name;
        public int GetPrice() => price;
        public string GetCode() => code;
    }
}