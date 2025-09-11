namespace ConsoleApp.Design_Patterns.Command
{
    class SetTemperatureCommand : ICommand
    {
        private Thermostat thermostat;
        private double temperature;
        private double previousTemperature;

        public SetTemperatureCommand(Thermostat thermostat, double temperature)
        {
            this.thermostat = thermostat;
            this.temperature = temperature;
        }

        public void Execute()
        {
            previousTemperature = thermostat.GetTemperature();
            thermostat.SetTemperature(temperature);
        }

        public void Undo()
        {
            thermostat.SetTemperature(previousTemperature);
        }

    }
}