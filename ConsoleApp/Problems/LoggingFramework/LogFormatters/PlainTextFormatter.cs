using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogFormatters
{
    public class PlainTextFormatter : LogFormatter
    {
        public string Format(LogMessage logMessage)
        {
            return $"[{logMessage.GetTimestamp()}][{logMessage.GetLevel()}] - {logMessage.GetMessage()}";
        }
    }
}