namespace ConsoleApp.Design_Patterns.Singleton
{
    public class Main
    {
        public static void main()
        {
            Logger logger = Logger.GetInstance();
            
            logger.LogInfo("This is info message.");
            logger.LogError("This is error message.");
            logger.LogDebug("This is debug message.");
        }
    }
}
