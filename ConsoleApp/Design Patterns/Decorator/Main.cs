namespace ConsoleApp.Design_Patterns.Decorator
{
    class Main
    {
        public static void main()
        {
            PlainText plainText = new PlainText("Hello World");
            plainText.Render();

            Console.WriteLine();

            BoldText boldText = new BoldText(plainText);
            ItalicText italicText = new ItalicText(boldText);
            UnderlinedText underlinedText = new UnderlinedText(italicText);

            underlinedText.Render();
        }
    }
}
