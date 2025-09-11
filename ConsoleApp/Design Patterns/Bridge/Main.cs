namespace ConsoleApp.Design_Patterns.Bridge
{
    class Main
    {
        public static void main()
        {
            IRenderer vectorRenderer = new VectorRenderer();
            Rectangle rectangle = new Rectangle(vectorRenderer, 10, 20);
            Circle circle = new Circle(vectorRenderer, 5.0f);

            rectangle.Draw();
            circle.Draw();

            IRenderer rasterRenderer = new RasterRenderer();
            rectangle = new Rectangle(rasterRenderer, 5, 10);
            circle = new Circle(rasterRenderer, 2.5f);

            rectangle.Draw();
            circle.Draw();
        }
    }
}
