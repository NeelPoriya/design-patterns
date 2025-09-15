using ConsoleApp.Problems.LoggingFramework.LogHandlers;
using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework
{
    public class Logger
    {
        private static readonly Logger instance = new Logger();

        private LogHandler handler;

        Logger()
        {
            this.handler = LogHandlerConfiguration.Build();
        }

        public static Logger GetInstance() => instance;

        public void Info(string message)
        {
            Log(message, LogType.INFO);
        }

        public void Warn(string message)
        {
            Log(message, LogType.WARN);
        }

        public void Error(string message)
        {
            Log(message, LogType.ERROR);
        }

        private void Log(string message, LogType logType)
        {
            handler.Handle(new LogMessage(message, logType, DateTimeOffset.UtcNow));
        }
    }
}