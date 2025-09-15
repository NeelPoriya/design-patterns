using ConsoleApp.Problems.StackOverflow.Enum;

namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class Question : Post
    {
        private string title;
        private HashSet<Tag> tags = [];
        private List<Answer> answers = [];
        private Answer? acceptedAnswer = null;
        public Question(string title, string body, User user, HashSet<Tag> tags) : base(body, user)
        {
            this.title = title;
            this.tags = tags;
        }

        public void AddAnswer(Answer answer)
        {
            this.answers.Add(answer);
        }

        public void AcceptAnswer(Answer answer)
        {
            lock (this)
            {
                if (!author.GetId().Equals(answer.GetAuthor().GetId()) && acceptedAnswer == null)
                {
                    acceptedAnswer = answer;
                    acceptedAnswer.SetAccepted(true);
                    NotifyObservers(new Event(EventType.ACCEPT_ANSWER, answer.GetAuthor(), this));
                }
            }
        }

        public string GetTitle() => title;
        public HashSet<Tag> GetTags() => tags;
        public List<Answer> GetAnswers() => answers;
    }
}