using ConsoleApp.Problems.TicTacToe.State;
using ConsoleApp.Problems.TicTacToe.Strategy;

namespace ConsoleApp.Problems.TicTacToe.Models;

public class Game
{
    private Board board;
    private Player player1, player2;
    private Player currentPlayer;
    private IGameState gameState;
    private List<IWinningStrategy> winningStrategies;

    public Game(int rows, int cols, Player player1, Player player2)
    {
        board = new Board(rows, cols);
        this.player1 = player1;
        this.player2 = player2;
        this.currentPlayer = player1;
        this.gameState = new InProgressGameState(this);
        winningStrategies = new List<IWinningStrategy> {
            new ColumnWinningStrategy(),
            new RowWinningStrategy(),
            new DiagonalWinningStrategy()
        };
    }

    public void Reset()
    {
        currentPlayer = player1;
        board.Clear();
    }

    public Board GetBoard() => board;
    public Player GetCurrentPlayer() => currentPlayer;
    public bool HasWon()
    {
        foreach (IWinningStrategy winningStrategy in winningStrategies)
        {
            if (winningStrategy.HasWon(board, currentPlayer)) return true;
        }
        return false;
    }

    public void SetGameState(IGameState gameState)
    {
        this.gameState = gameState;
    }

    public void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == player1) ? player2 : player1;
    }

    public void MakeMove(int row, int col)
    {
        this.gameState.MakeMove(row, col);
    }

    public bool IsGameOver()
    {
        return gameState.GetType() != typeof(InProgressGameState);
    }
}
