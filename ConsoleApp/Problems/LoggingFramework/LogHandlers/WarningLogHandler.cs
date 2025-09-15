using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogHandlers
{
    public class WarningLogHandler : LogHandler
    {
        protected override bool CanHandle(LogMessage message)
        {
            return message.GetLevel() == LogType.WARN;
        }
    }
}