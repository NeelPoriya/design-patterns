using ConsoleApp.Problems.TicTacToe.Models;

namespace ConsoleApp.Problems.TicTacToe.State;

public class InProgressGameState : IGameState
{
    private Game game;

    public InProgressGameState(Game game)
    {
        this.game = game;
    }
    public void MakeMove(int row, int col)
    {
        Board board = game.GetBoard();
        if (!board.IsCellAvailableAt(row, col))
        {
            Console.WriteLine($"Cell ({row}, {col}) is already filled");
            return;
        }

        Player currentPlayer = game.GetCurrentPlayer();
        board.SetCell(row, col, currentPlayer.GetSymbol());

        // Check if current player won
        if (game.HasWon())
        {
            board.PrintBoard();
            Console.WriteLine($"Player {currentPlayer.GetName()} has won!!!");
            game.SetGameState(new WonState());
        }

        // Check if game is a draw
        if (!board.IsAnyCellEmpty())
        {
            board.PrintBoard();
            Console.WriteLine($"Game ended in draw!");
            game.SetGameState(new DrawState());
        }

        game.SwitchPlayer();
    }
}
