using ConsoleApp.Problems.LoggingFramework.LogAppenders;
using ConsoleApp.Problems.LoggingFramework.LogHandlers;

namespace ConsoleApp.Problems.LoggingFramework
{
    public class LogHandlerConfiguration
    {
        private static LogHandler infoHandler = new InfoLogHandler();
        private static LogHandler warningHandler = new WarningLogHandler();
        private static LogHandler errorHandler = new ErrorLogHandler();

        public static LogHandler Build()
        {
            infoHandler.SetNext(warningHandler);
            warningHandler.SetNext(errorHandler);
            return infoHandler;
        }

        public static void AddAppenderToLevel(LogType level, LogAppender appender)
        {
            switch (level)
            {
                case LogType.INFO:
                    infoHandler.AddAppender(appender);
                    break;
                case LogType.ERROR:
                    errorHandler.AddAppender(appender);
                    break;
                case LogType.WARN:
                    warningHandler.AddAppender(appender);
                    break;
                default:
                    Console.WriteLine($"Invalid log level type: {level}");
                    break;
            }
        }
    }
}