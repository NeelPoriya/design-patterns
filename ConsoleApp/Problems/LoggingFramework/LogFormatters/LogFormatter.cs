using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogFormatters
{
    public interface LogFormatter
    {
        string Format(LogMessage logMessage);
    }
}