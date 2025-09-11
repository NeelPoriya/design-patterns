namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
