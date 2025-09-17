namespace ConsoleApp.Problems.TicTacToe.State;

public class DrawState : IGameState
{
    public void MakeMove(int row, int col)
    {
        Console.WriteLine($"Cannot make a move. Game has ended in a draw.");
    }
}
