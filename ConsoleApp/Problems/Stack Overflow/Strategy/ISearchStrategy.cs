using ConsoleApp.Problems.StackOverflow.Models;

namespace ConsoleApp.Problems.StackOverflow.Strategy
{
    public interface ISearchStrategy
    {
        List<Question> Filter(List<Question> questions);
    }
}