namespace ConsoleApp.Design_Patterns.Command
{
    class Light
    {
        public void LightOn()
        {
            Console.WriteLine($"Turning Light on💡");
        }

        public void LightOff()
        {
            Console.WriteLine($"Turning Light off🔅");
        }
    }
}