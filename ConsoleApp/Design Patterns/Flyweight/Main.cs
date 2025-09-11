namespace ConsoleApp.Design_Patterns.Flyweight
{
    class Main
    {
        public static void main()
        {
            TextEditorClient textEditorClient = new TextEditorClient();

            string word = "Hello";
            for (int i = 0; i < word.Length; ++i)
            {
                textEditorClient.AddCharacter(word[i], 10 * i + 15, i, "Times New Roman", "#ffffff", 25.0f);
            }

            string word2 = "World";
            for (int j = 0; j < word2.Length; ++j)
            {
                textEditorClient.AddCharacter(word2[j], 10 * j + 20, j * 10, "Arial", "#000000", 20.0f);
            }

            textEditorClient.RenderCharacters();
        }
    }
}
