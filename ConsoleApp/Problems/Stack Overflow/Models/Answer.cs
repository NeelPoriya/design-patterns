namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class Answer : Post
    {
        private bool accepted;
        private string questionId;
        public Answer(string body, string questionId, User user) : base(body, user)
        {
            this.accepted = false;
            this.questionId = questionId;
        }

        public void SetAccepted(bool value)
        {
            this.accepted = value;
        }
    }
}