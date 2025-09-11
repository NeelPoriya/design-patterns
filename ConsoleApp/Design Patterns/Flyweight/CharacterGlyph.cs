namespace ConsoleApp.Design_Patterns.Flyweight
{
    class CharacterGlyph : ICharacterFlyweight
    {
        private char character;
        private string fontFamily = "";
        private string color = "";
        private readonly float fontSize;

        public CharacterGlyph(char character, string fontFamily, string color, float fontSize)
        {
            this.character = character;
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Rendering character {character} at ({x}, {y}). [Font family: {fontFamily}, Font color: {color}, Font size: {fontSize}]");
        }
    }
}
