using ConsoleApp.Problems.LoggingFramework.LogFormatters;
using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogAppenders
{
    public abstract class LogAppender
    {
        protected LogFormatter formatter;

        public LogAppender(LogFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void SetFormatter(LogFormatter formatter)
        {
            this.formatter = formatter;
        }

        public LogFormatter GetFormatter() => formatter;

        public abstract void Append(LogMessage logMessage);
    }
}