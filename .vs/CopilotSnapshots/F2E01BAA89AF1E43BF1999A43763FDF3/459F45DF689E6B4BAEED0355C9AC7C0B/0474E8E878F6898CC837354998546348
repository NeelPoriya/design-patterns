using System;

namespace ConsoleApp.Design_Patterns.Singleton
{
    public class Logger
    {
        private static Logger instance;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void LogInfo(string message)
        {
            WriteLog("INFO", message);
        }

        public void LogError(string message)
        {
            WriteLog("ERROR", message);
        }

        public void LogDebug(string message)
        {
            WriteLog("DEBUG", message);
        }

        private void WriteLog(string level, string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"[{timestamp}] [{level}] {message}");
        }
    }
}
