namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class Comment
    {
        private string id;
        private string content;
        private User author;

        public Comment(string content, User author)
        {
            id = Guid.NewGuid().ToString();
            this.content = content;
            this.author = author;
        }
    }
}