using System.Collections.Concurrent;
using ConsoleApp.Problems.StackOverflow.Enum;
using ConsoleApp.Problems.StackOverflow.Interface;

namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class Post : Content
    {
        private int voteCount = 0;
        private ConcurrentDictionary<string, VoteType> voters = [];
        private readonly List<Comment> comments = [];
        private readonly List<IPostObserver> postObservers = [];
        private static object voteLock = new object();
        public Post(string body, User user) : base(body, user) { }

        public void AddObserver(IPostObserver observer)
        {
            this.postObservers.Add(observer);
        }

        public void NotifyObservers(Event @event)
        {
            foreach (IPostObserver observer in postObservers)
            {
                observer.OnPostEvent(@event);
            }
        }

        public void Vote(User user, VoteType voteType)
        {
            lock (voteLock)
            {
                string userId = user.GetId();

                if (voters.TryGetValue(userId, out VoteType vote) && vote == voteType)
                {
                    Console.WriteLine($"User {userId} has already voted on Post {id}");
                    return;
                }

                int change = 0;
                if (voters.ContainsKey(userId))
                {
                    change = voteType == VoteType.DOWNVOTE ? -2 : 2;
                }
                else
                {
                    change = voteType == VoteType.DOWNVOTE ? -1 : 1;
                    voteCount++;
                }

                voters[userId] = voteType;

                EventType eventType;
                if (this is Question)
                {
                    eventType = voteType == VoteType.DOWNVOTE ? EventType.DOWNVOTE_QUESTION : EventType.UPVOTE_QUESTION;
                }
                else
                {
                    eventType = voteType == VoteType.DOWNVOTE ? EventType.DOWNVOTE_ANSWER : EventType.UPVOTE_ANSWER;
                }

                NotifyObservers(new Event(eventType, author, this));
            }
        }
    }
}