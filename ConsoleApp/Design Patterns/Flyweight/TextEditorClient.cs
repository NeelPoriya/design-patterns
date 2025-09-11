namespace ConsoleApp.Design_Patterns.Flyweight
{
    class TextEditorClient
    {
        private CharacterFlyweightFactory characterFlyweightFactory = new CharacterFlyweightFactory();
        private readonly List<CharacterRenderer> characterRenderers = new List<CharacterRenderer>();

        public void AddCharacter(char c, int x, int y, string fontFamily, string color, float size)
        {
            ICharacterFlyweight flyweight = characterFlyweightFactory.GetCharacterFlyweight(c, color, fontFamily, size);
            characterRenderers.Add(new CharacterRenderer(flyweight, x, y));
        }

        public void RenderCharacters()
        {
            foreach (CharacterRenderer characterRenderer in characterRenderers)
            {
                characterRenderer.Render();
            }
            Console.WriteLine($"Total flyweight objects used: {characterFlyweightFactory.GetCharacterFlyweightSize()}");
        }
    }
}
