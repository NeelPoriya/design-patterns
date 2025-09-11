namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
