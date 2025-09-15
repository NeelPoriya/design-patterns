using ConsoleApp.Problems.LoggingFramework.LogFormatters;
using ConsoleApp.Problems.LoggingFramework.Models;

namespace ConsoleApp.Problems.LoggingFramework.LogAppenders
{
    public class FileAppender : LogAppender
    {
        private StreamWriter writer;
        public FileAppender(LogFormatter formatter, string path) : base(formatter)
        {
            writer = new StreamWriter(path, append: true);
        }

        public override void Append(LogMessage logMessage)
        {
            string formattedString = formatter.Format(logMessage);
            writer.WriteLine(formattedString);
            writer.Flush();
        }
    }
}