using ConsoleApp.Design_Patterns.Factory.Normal;

namespace ConsoleApp.Design_Patterns.Factory.Factory_Method
{
    public class SMSNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
