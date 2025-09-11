namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    class Application
    {
        IButton _button;
        ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void Render()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}
