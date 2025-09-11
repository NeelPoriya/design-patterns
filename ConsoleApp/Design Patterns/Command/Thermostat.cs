namespace ConsoleApp.Design_Patterns.Command
{
    class Thermostat
    {
        private double temperature;

        public Thermostat()
        {
            this.temperature = 0;
        }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public double GetTemperature()
        {
            return this.temperature;
        }
    }
}