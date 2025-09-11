namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }
    }
}
