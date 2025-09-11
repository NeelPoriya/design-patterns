namespace ConsoleApp.Design_Patterns.Decorator
{
    class PlainText(string text) : ITextView
    {
        public void Render()
        {
            Console.Write(text);
        }
    }
}
