namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    public class WindowButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine($"Painting a windows button");
        }

        public void OnClick()
        {
            Console.WriteLine($"Clicking on windows button");
        }
    }
}
