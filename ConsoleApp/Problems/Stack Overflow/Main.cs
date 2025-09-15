using ConsoleApp.Problems.StackOverflow.Enum;
using ConsoleApp.Problems.StackOverflow.Models;
using ConsoleApp.Problems.StackOverflow.Strategy;

namespace ConsoleApp.Problems.StackOverflow
{
    public class Main
    {
        public static void main()
        {
            StackOverflowService stackOverflowService = new();

            // 1. Create users
            User alice = stackOverflowService.CreateUser("alice");
            User bob = stackOverflowService.CreateUser("bob");
            User charlie = stackOverflowService.CreateUser("charlie");

            // 2. Alice posts a question
            Console.WriteLine("---Alice posts a question---");
            Tag cSharpTag = new Tag("C#");
            Tag designPatternTag = new Tag("design-pattern");
            HashSet<Tag> tags = new HashSet<Tag> { cSharpTag, designPatternTag };
            Question question = stackOverflowService.PostQuestion(alice.GetId(), "How to implement observer pattern?", "Details about observer pattern...", tags);
            PrintReputations(alice, charlie, bob);

            // 3. Bob and Charlie posts answer
            Console.WriteLine($"---Bob And Charlie posts answer---");
            Answer bobAnswer = stackOverflowService.PostAnswer(bob.GetId(), question.GetId(), "You can use the java.util.Observer interface.");
            Answer charlieAnswer = stackOverflowService.PostAnswer(charlie.GetId(), question.GetId(), "A better way is to create your own Observer interface.");
            PrintReputations(alice, bob, charlie);

            // 4. Voting happens
            Console.WriteLine("\n--- Voting Occurs ---");
            stackOverflowService.VoteOnPost(alice.GetId(), question.GetId(), VoteType.UPVOTE);
            stackOverflowService.VoteOnPost(bob.GetId(), charlieAnswer.GetId(), VoteType.UPVOTE);
            stackOverflowService.VoteOnPost(alice.GetId(), bobAnswer.GetId(), VoteType.DOWNVOTE);
            PrintReputations(alice, bob, charlie);

            // 5. Alice accepts Charlie's answer
            Console.WriteLine("\n--- Alice accepts Charlie's answer ---");
            stackOverflowService.AcceptAnswer(question.GetId(), charlieAnswer.GetId());
            PrintReputations(alice, bob, charlie);

            // 6. Search for questions
            Console.WriteLine("\n--- (C) Combined Search: Questions by 'Alice' with tag 'c#' ---");
            List<ISearchStrategy> filtersC = new List<ISearchStrategy>
            {
                new UserSearchStrategy(alice),
                new TagSearchStrategy(cSharpTag)
            };
            List<Question> searchResults = stackOverflowService.SearchQuestion(filtersC);
            foreach (var q in searchResults)
            {
                Console.WriteLine($"  - Found: {q.GetTitle()}");
            }
        }

        private static void PrintReputations(params User[] users)
        {
            Console.WriteLine("--- Current Reputations ---");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.GetName()}: {user.GetReputation()}");
            }
        }
    }
}