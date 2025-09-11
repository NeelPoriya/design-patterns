namespace ConsoleApp.Design_Patterns.Bridge
{
    interface IRenderer
    {
        void RenderCircle(float radius);
        void RenderRectangle(int width, int height);
    }
}
