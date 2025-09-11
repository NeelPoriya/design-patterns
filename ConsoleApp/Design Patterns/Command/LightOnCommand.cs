namespace ConsoleApp.Design_Patterns.Command
{
    class LightOnCommand : ICommand
    {
        private Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.LightOn();
        }

        public void Undo()
        {
            light.LightOff();
        }
    }
}