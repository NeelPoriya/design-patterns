using System.Collections.Concurrent;
using ConsoleApp.Problems.StackOverflow.Enum;
using ConsoleApp.Problems.StackOverflow.Models;
using ConsoleApp.Problems.StackOverflow.Observer;
using ConsoleApp.Problems.StackOverflow.Strategy;

namespace ConsoleApp.Problems.StackOverflow
{
    public class StackOverflowService
    {
        private readonly ConcurrentDictionary<string, User> users = [];
        private readonly ConcurrentDictionary<string, Question> questions = [];
        private readonly ConcurrentDictionary<string, Answer> answers = [];
        private readonly ReputationManager reputationManager = new ReputationManager();

        public StackOverflowService()
        {
        }

        public User CreateUser(string name)
        {
            User user = new User(name);
            users.TryAdd(user.GetId(), user);
            return user;
        }

        public Question PostQuestion(string userId, string title, string body, HashSet<Tag> tags)
        {
            User user = users[userId];
            Question question = new Question(title, body, user, tags);
            questions.TryAdd(question.GetId(), question);
            question.AddObserver(reputationManager);
            return question;
        }

        public Answer PostAnswer(string userId, string questionId, string body)
        {
            User user = users[userId];
            Question question = questions[questionId];

            Answer answer = new Answer(body, questionId, user);
            answer.AddObserver(reputationManager);
            answers.TryAdd(answer.GetId(), answer);
            question.AddAnswer(answer);

            return answer;
        }

        public void VoteOnPost(string userId, string postId, VoteType voteType)
        {
            Post post = FindPostById(postId);
            User user = GetUser(userId);
            post.Vote(user, voteType);
        }

        public void AcceptAnswer(string questionId, string answerId)
        {
            Question question = questions[questionId];
            Answer answer = answers[answerId];
            question.AcceptAnswer(answer);
        }

        public User GetUser(string userId)
        {
            return users[userId];
        }

        public List<Question> SearchQuestion(List<ISearchStrategy> searchStrategies)
        {
            List<Question> result = questions.Values.ToList();

            foreach (ISearchStrategy strategy in searchStrategies)
            {
                result = strategy.Filter(result);
            }

            return result;
        }

        Post FindPostById(string id)
        {
            if (questions.TryGetValue(id, out Question? post))
            {
                return post;
            }
            else if (answers.TryGetValue(id, out Answer? answer))
            {
                return answer;
            }

            throw new KeyNotFoundException($"Post {id} not found");
        }
    }
}