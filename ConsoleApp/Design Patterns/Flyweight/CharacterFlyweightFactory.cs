namespace ConsoleApp.Design_Patterns.Flyweight
{
    class CharacterFlyweightFactory
    {
        private readonly Dictionary<string, ICharacterFlyweight> characterFactory = [];
        public ICharacterFlyweight GetCharacterFlyweight(char c, string color, string fontFamily, float fontSize)
        {
            string key = c + color + fontFamily + fontSize;
            if (characterFactory.TryGetValue(key, out ICharacterFlyweight? value))
            {
                return value;
            }

            return characterFactory[key] = new CharacterGlyph(c, fontFamily, color, fontSize);
        }

        public int GetCharacterFlyweightSize()
        {
            return characterFactory.Count;
        }
    }
}
