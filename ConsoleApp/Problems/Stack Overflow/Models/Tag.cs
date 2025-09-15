namespace ConsoleApp.Problems.StackOverflow.Models
{
    public class Tag : IComparable<Tag>
    {
        private readonly string id;
        private string name;

        public Tag(string name)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
        }

        public int CompareTo(Tag? other)
        {
            return string.Compare(this.name, other?.GetName(), StringComparison.Ordinal);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Tag other)
            {
                return string.Equals(this.name, other.GetName(), StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.name.ToLower().GetHashCode();
        }

        public string GetId() => id;
        public string GetName() => name;
    }
}