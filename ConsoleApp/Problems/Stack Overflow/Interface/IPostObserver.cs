using ConsoleApp.Problems.StackOverflow.Models;

namespace ConsoleApp.Problems.StackOverflow.Interface
{
    public interface IPostObserver
    {
        void OnPostEvent(Event eventObj);
    }
}