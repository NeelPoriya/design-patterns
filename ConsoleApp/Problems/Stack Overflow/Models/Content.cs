namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class Content
    {
        protected readonly string id;
        protected readonly string body;
        protected readonly User author;
        protected DateTime createdAt;

        public Content(string body, User user)
        {
            this.id = Guid.NewGuid().ToString();
            this.body = body;
            this.author = user;
            createdAt = DateTime.UtcNow;
        }

        public string GetId() => id;
        public string GetBody() => body;
        public User GetAuthor() => author;
    }
}