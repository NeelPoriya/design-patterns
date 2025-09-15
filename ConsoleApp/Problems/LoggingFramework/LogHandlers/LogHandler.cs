using System.ComponentModel;
using ConsoleApp.Problems.LoggingFramework.LogAppenders;
using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogHandlers
{
    public abstract class LogHandler
    {
        private List<LogAppender> appenders = [];
        protected LogHandler? next = null;

        public void SetNext(LogHandler? next)
        {
            this.next = next;
        }

        public void AddAppender(LogAppender appender)
        {
            appenders.Add(appender);
        }

        public void RemoveAppender(LogAppender appender)
        {
            appenders.Remove(appender);
        }

        protected void NotifyAppenders(LogMessage logMessage)
        {
            foreach (LogAppender appender in appenders)
            {
                appender.Append(logMessage);
            }
        }

        public void Handle(LogMessage message)
        {
            if (CanHandle(message))
            {
                NotifyAppenders(message);
            }
            else
            {
                next?.Handle(message);
            }
        }

        protected abstract bool CanHandle(LogMessage message);
    }
}