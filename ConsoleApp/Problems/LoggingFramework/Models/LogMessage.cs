namespace ConsoleApp.Problems.LoggingFramework.Models
{
    public class LogMessage
    {
        private readonly string message;
        private readonly LogType level;
        private readonly DateTimeOffset timestamp;

        public LogMessage(string message, LogType logType, DateTimeOffset timestamp)
        {
            this.message = message;
            this.level = logType;
            this.timestamp = timestamp;
        }

        public string GetMessage() => message;
        public LogType GetLevel() => level;
        public DateTimeOffset GetTimestamp() => timestamp;
    }
}