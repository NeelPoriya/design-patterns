namespace ConsoleApp.Design_Patterns.Bridge
{
    class Rectangle : Shape
    {
        private readonly int width, height;

        public Rectangle(IRenderer renderer, int width, int height) : base(renderer)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw()
        {
            this.renderer.RenderRectangle(this.width, this.height);
        }
    }
}
