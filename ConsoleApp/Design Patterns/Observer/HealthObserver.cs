using System.Text.Json;

namespace ConsoleApp.Design_Patterns.Observer
{
    class HealthObserver : IObserver
    {
        public void Update(FitnessData fitnessData)
        {
            Console.WriteLine($"HealthObserver | Fitness Data received : {JsonSerializer.Serialize(fitnessData)}");
        }
    }
}
