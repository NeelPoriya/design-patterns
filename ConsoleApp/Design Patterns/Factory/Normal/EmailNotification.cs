namespace ConsoleApp.Design_Patterns.Factory.Normal
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
}
