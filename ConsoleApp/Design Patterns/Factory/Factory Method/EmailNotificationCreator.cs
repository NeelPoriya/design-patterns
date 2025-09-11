using ConsoleApp.Design_Patterns.Factory.Normal;

namespace ConsoleApp.Design_Patterns.Factory.Factory_Method
{
    class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
