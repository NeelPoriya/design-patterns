namespace ConsoleApp.Design_Patterns.Flyweight
{
    class CharacterRenderer
    {
        private readonly ICharacterFlyweight characterFlyweight;
        private readonly int x, y;

        public CharacterRenderer(ICharacterFlyweight characterFlyweight, int x, int y)
        {
            this.characterFlyweight = characterFlyweight;
            this.x = x;
            this.y = y;
        }

        public void Render()
        {
            characterFlyweight.Draw(x, y);
        }
    }
}
