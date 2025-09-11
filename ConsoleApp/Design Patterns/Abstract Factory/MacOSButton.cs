namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    public class MacOSButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine($"Painting a MacOS Button");
        }

        public void OnClick()
        {
            Console.WriteLine($"Cliking on MacOS Button");
        }
    }
}
