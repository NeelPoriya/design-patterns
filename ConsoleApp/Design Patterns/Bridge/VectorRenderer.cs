namespace ConsoleApp.Design_Patterns.Bridge
{
    class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Render a circle of radius {radius} with Vector Renderer");
        }

        public void RenderRectangle(int width, int height)
        {
            Console.WriteLine($"Render a rectangle of width {width} and height {height} with Vector Renderer");
        }
    }
}
