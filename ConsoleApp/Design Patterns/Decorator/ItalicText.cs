namespace ConsoleApp.Design_Patterns.Decorator
{
    class ItalicText(ITextView view) : TextDecorator(view)
    {
        public override void Render()
        {
            Console.Write("<i>");
            view.Render();
            Console.Write("</i>");
        }
    }
}
