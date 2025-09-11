namespace ConsoleApp.Design_Patterns.Factory.Normal
{
    public static class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SMSNotification(),
                _ => throw new ArgumentException($"Invalid notification type {type}"),
            };
        }
    }
}
