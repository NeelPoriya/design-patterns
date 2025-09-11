namespace ConsoleApp.Design_Patterns.Decorator
{
    class UnderlinedText(ITextView view) : TextDecorator(view)
    {
        public override void Render()
        {
            Console.Write("<u>");
            view.Render();
            Console.Write("</u>");
        }
    }
}
