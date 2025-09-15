using ConsoleApp.Problems.StackOverflow.Enum;
using ConsoleApp.Problems.StackOverflow.Interface;
using ConsoleApp.Problems.StackOverflow.Models;

namespace ConsoleApp.Problems.StackOverflow.Observer
{
    public class ReputationManager : IPostObserver
    {
        private const int ACCEPT_ANSWER_REP = 10;
        private const int DOWNVOTE_ANSWER_REP = -2;
        private const int DOWNVOTE_QUESTION_REP = -1;
        private const int UPVOTE_ANSWER_REP = 5;
        private const int UPVOTE_QUESTION_REP = 10;
        public void OnPostEvent(Event eventObj)
        {
            EventType eventType = eventObj.GetEventType();
            User postAuthor = eventObj.GetUser();

            switch (eventType)
            {
                case EventType.ACCEPT_ANSWER:
                    postAuthor.UpdateReputation(ACCEPT_ANSWER_REP);
                    break;
                case EventType.DOWNVOTE_ANSWER:
                    postAuthor.UpdateReputation(DOWNVOTE_ANSWER_REP);
                    break;
                case EventType.DOWNVOTE_QUESTION:
                    postAuthor.UpdateReputation(DOWNVOTE_QUESTION_REP);
                    break;
                case EventType.UPVOTE_ANSWER:
                    postAuthor.UpdateReputation(UPVOTE_ANSWER_REP);
                    break;
                case EventType.UPVOTE_QUESTION:
                    postAuthor.UpdateReputation(UPVOTE_QUESTION_REP);
                    break;
                default:
                    throw new InvalidOperationException($"Event type : {eventType} is not valid");
            }
        }
    }
}