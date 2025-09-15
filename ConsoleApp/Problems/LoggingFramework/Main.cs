using ConsoleApp.Problems.LoggingFramework.LogAppenders;
using ConsoleApp.Problems.LoggingFramework.LogFormatters;

namespace ConsoleApp.Problems.LoggingFramework
{
    public class Main
    {
        public static void main()
        {
            Logger logger = Logger.GetInstance();

            JsonFormatter jsonFormatter = new JsonFormatter();

            LogHandlerConfiguration.AddAppenderToLevel(LogType.INFO, new ConsoleAppender(jsonFormatter));
            LogHandlerConfiguration.AddAppenderToLevel(LogType.WARN, new ConsoleAppender(jsonFormatter));
            LogHandlerConfiguration.AddAppenderToLevel(LogType.ERROR, new ConsoleAppender(jsonFormatter));
            LogHandlerConfiguration.AddAppenderToLevel(LogType.ERROR, new FileAppender(jsonFormatter, Directory.GetCurrentDirectory() + "/app.log"));

            logger.Info("This is a info message");
            logger.Warn("This is warning message");
            logger.Error("This is error message");
        }
    }
}