namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class User
    {
        private string id;
        private string name;
        private int reputation;
        private static readonly object reputationLock = new object();

        public User(string name)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
            this.reputation = 0;
        }

        public void UpdateReputation(int change)
        {
            lock (reputationLock)
            {
                reputation += change;
            }
        }

        public string GetId() => id;
        public string GetName() => name;
        public int GetReputation()
        {
            lock (reputationLock)
            {
                return reputation;
            }
        }
    }
}