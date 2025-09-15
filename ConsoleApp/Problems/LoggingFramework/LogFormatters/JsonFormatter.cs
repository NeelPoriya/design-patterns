using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogFormatters
{
    public class JsonFormatter : LogFormatter
    {
        public string Format(LogMessage message)
        {
            return $"{{\"timestamp\":\"{message.GetTimestamp().ToUnixTimeMilliseconds()}\",\"message\":\"{message.GetMessage()}\",\"level\":\"{message.GetLevel()}\"}}";
        }
    }
}