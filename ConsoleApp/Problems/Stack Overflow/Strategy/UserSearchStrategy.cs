using ConsoleApp.Problems.StackOverflow.Models;

namespace ConsoleApp.Problems.StackOverflow.Strategy
{
    public class UserSearchStrategy : ISearchStrategy
    {
        private User user;
        public UserSearchStrategy(User user)
        {
            this.user = user;
        }

        public List<Question> Filter(List<Question> questions)
        {
            return questions
                .Where(q => q.GetAuthor().GetId().Equals(user.GetId()))
                .ToList();
        }
    }
}