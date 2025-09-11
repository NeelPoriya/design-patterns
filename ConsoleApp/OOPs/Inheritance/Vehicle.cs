namespace ConsoleApp.OOPS.Inheritance
{
    public class Vehicle
    {
        public int Speed { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Driving at {Speed} kmph");
        }
    }
}
