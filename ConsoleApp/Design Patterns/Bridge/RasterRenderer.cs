namespace ConsoleApp.Design_Patterns.Bridge
{
    class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Rendering a circle of radius {radius} with Raster Renderer");
        }

        public void RenderRectangle(int width, int height)
        {
            Console.WriteLine($"Rendering a rectangle of width {width} and height {height} with Raster Renderer");
        }
    }
}
