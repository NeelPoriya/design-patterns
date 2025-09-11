namespace ConsoleApp.Design_Patterns.Factory.Normal
{
    public class Main
    {
        public static void main()
        {
            INotification emailNotification = NotificationFactory.CreateNotification("email");
            emailNotification.Send("Hello via Email!");

            INotification smsNotification = NotificationFactory.CreateNotification("sms");
            smsNotification.Send("Hello via SMS!");
        }
    }
}
