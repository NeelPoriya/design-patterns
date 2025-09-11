namespace ConsoleApp.Design_Patterns.Command
{
    class SmartButton
    {
        ICommand? currentCommand = null;
        List<ICommand> commandHistory = [];

        public void SetCommand(ICommand command)
        {
            currentCommand = command;
        }

        public void Press()
        {
            if (currentCommand != null)
            {
                this.currentCommand.Execute();
                commandHistory.Add(currentCommand);
            }
            else
            {
                Console.WriteLine($"No command found!");
            }
        }

        public void UndoLast()
        {
            if (commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Last();
                lastCommand.Undo();
                commandHistory.Remove(lastCommand);
            }
            else
            {
                Console.WriteLine($"Nothing to undo");
            }
        }
    }
}