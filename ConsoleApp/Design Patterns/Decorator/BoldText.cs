namespace ConsoleApp.Design_Patterns.Decorator
{
    class BoldText(ITextView view) : TextDecorator(view)
    {
        public override void Render()
        {
            Console.Write("<b>");
            view.Render();
            Console.Write("</b>");
        }
    }
}
