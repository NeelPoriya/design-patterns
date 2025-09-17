using ConsoleApp.Problems.TicTacToe.Models;

namespace ConsoleApp.Problems.TicTacToe.Strategy;

public class DiagonalWinningStrategy : IWinningStrategy
{
    public bool HasWon(Board board, Player player)
    {
        int i = 0, j = 0;
        bool result = true;
        while (i < board.GetRows() && j < board.GetCols())
        {
            if (!Equals(player.GetSymbol(), board.GetCellAt(i, j)?.GetSymbol()))
            {
                result = false;
                break;
            }
            ++i; ++j;
        }

        if (result) return true;

        i = board.GetRows() - 1; j = 0;
        while (i >= 0 && j < board.GetCols())
        {
            if (!Equals(player.GetSymbol(), board.GetCellAt(i, j)?.GetSymbol()))
            {
                return false;
            }
            --i; ++j;
        }
        return true;
    }
}
