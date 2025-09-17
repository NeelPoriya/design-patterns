using ConsoleApp.Problems.TicTacToe.Models;

namespace ConsoleApp.Problems.TicTacToe.Strategy;

public interface IWinningStrategy
{
    bool HasWon(Board board, Player player);
}
