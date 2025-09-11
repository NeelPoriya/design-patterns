namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    public class MacOSCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine($"Painting a MacOS checkbox");
        }

        public void OnSelect()
        {
            Console.WriteLine($"Selecting a MacOS Checkbox");
        }
    }
}
