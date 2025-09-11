namespace ConsoleApp.Design_Patterns.Observer
{
    class Main
    {
        public static void main()
        {
            FitnessData fitnessData = new FitnessData(10, "there");

            HealthObserver healthObserver = new();
            WatchObserver watchObserver = new();

            fitnessData.AddObserver(healthObserver);
            fitnessData.AddObserver(watchObserver);

            fitnessData.UpdateFitnessData(20, "New Data");

            fitnessData.RemoveObserver(healthObserver);

            fitnessData.UpdateFitnessData(30, "New New Data");
            
        }
    }
}
