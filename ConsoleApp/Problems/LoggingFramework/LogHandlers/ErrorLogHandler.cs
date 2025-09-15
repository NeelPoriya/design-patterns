using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogHandlers
{
    public class ErrorLogHandler : LogHandler
    {
        protected override bool CanHandle(LogMessage message)
        {
            return message.GetLevel() == LogType.ERROR;
        }
    }
}