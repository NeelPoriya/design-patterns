namespace ConsoleApp.Design_Patterns.Decorator
{
    abstract class TextDecorator : ITextView
    {
        protected readonly ITextView view;

        public TextDecorator(ITextView view)
        {
            this.view = view;
        }

        public abstract void Render();
    }
}
