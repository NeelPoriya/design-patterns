using ConsoleApp.Problems.StackOverflow.Enum;

namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class Event
    {
        private EventType eventType;
        private User actor;
        private Post targetPost;

        public Event(EventType eventType, User user, Post post)
        {
            this.eventType = eventType;
            this.actor = user;
            this.targetPost = post;
        }

        public EventType GetEventType() => eventType;
        public User GetUser() => actor;
        public Post GetPost() => targetPost;
    }
}