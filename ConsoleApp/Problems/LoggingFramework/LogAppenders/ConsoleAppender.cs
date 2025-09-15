using ConsoleApp.Problems.LoggingFramework.LogFormatters;
using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogAppenders
{
    public class ConsoleAppender : LogAppender
    {
        public ConsoleAppender(LogFormatter formatter) : base(formatter)
        {
        }

        public override void Append(LogMessage logMessage)
        {
            string formattedString = formatter.Format(logMessage);
            Console.WriteLine(formattedString);
        }
    }
}