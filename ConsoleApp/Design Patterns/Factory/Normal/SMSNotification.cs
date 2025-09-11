namespace ConsoleApp.Design_Patterns.Factory.Normal
{
    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
