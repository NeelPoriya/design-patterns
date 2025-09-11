namespace ConsoleApp.Design_Patterns.Command
{
    class Main
    {
        public static void main()
        {
            Light light = new Light();
            Thermostat thermostat = new Thermostat();

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            SetTemperatureCommand setTemperatureCommand = new SetTemperatureCommand(thermostat, 20);

            SmartButton button = new SmartButton();
            button.SetCommand(lightOnCommand);

            Console.WriteLine($"Pressing Light on");
            button.Press();

            button.SetCommand(lightOffCommand);

            Console.WriteLine("Pressing Light off");
            button.Press();

            button.SetCommand(setTemperatureCommand);

            Console.WriteLine("Setting temperature");
            button.Press();
        }
    }
}