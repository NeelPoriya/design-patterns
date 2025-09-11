using ConsoleApp.Design_Patterns.Factory.Normal;

namespace ConsoleApp.Design_Patterns.Factory.Factory_Method
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void Send(string message)
        {
            INotification notification = CreateNotification();
            notification.Send(message);
        }
    }
}
