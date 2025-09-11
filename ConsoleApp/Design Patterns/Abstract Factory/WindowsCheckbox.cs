namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine($"Paining a windows checkbox");
        }
        
        public void OnSelect()
        {
            Console.WriteLine("Selecing windows checkbox");
        }
    }
}
