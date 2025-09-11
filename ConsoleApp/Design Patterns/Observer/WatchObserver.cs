using System.Text.Json;

namespace ConsoleApp.Design_Patterns.Observer
{
    class WatchObserver : IObserver
    {
        public void Update(FitnessData fitnessData)
        {
            Console.WriteLine($"WatchObserver | Fitness Data is : {JsonSerializer.Serialize(fitnessData)}");
        }
    }
}
