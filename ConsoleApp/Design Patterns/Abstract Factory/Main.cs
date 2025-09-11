namespace ConsoleApp.Design_Patterns.Abstract_Factory
{
    class Main
    {
        public static void main()
        {
            string os = "mac";

            IGUIFactory factory;
            if (os.ToLower() == "win")
            {
                factory = new WindowsFactory();
            }
            else
            {
                factory = new MacOSFactory();
            }

            Application application = new Application(factory);
            application.Render();
        }
    }
}
