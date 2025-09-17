namespace ConsoleApp.Problems.TicTacToe.State;

public class WonState : IGameState
{
    public void MakeMove(int row, int col)
    {
        Console.WriteLine($"Cannot make move. Game has finished");
    }
}
