using ConsoleApp.Design_Patterns.Factory.Normal;

namespace ConsoleApp.Design_Patterns.Factory.Factory_Method
{
    class Main
    {
        public static void main()
        {
            INotification emailNotification = new EmailNotificationCreator().CreateNotification();
            emailNotification.Send("Hello via Email!");

            INotification smsNotification = new SMSNotificationCreator().CreateNotification();
            smsNotification.Send("Hello via SMS!");
        }
    }
}
