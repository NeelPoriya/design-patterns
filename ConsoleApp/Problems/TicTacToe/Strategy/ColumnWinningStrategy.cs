using ConsoleApp.Problems.TicTacToe.Enums;
using ConsoleApp.Problems.TicTacToe.Models;

namespace ConsoleApp.Problems.TicTacToe.Strategy;

public class ColumnWinningStrategy : IWinningStrategy
{
    public bool HasWon(Board board, Player player)
    {
        Symbol currentSymbol = player.GetSymbol();

        // iterate through each row of board to check if all symbols are equal to `currentSymbol`
        for (int j = 0; j < board.GetRows(); ++j)
        {
            bool hasWon = true;
            for (int i = 0; i < board.GetCols(); ++i)
            {
                if (!Equals(currentSymbol, board.GetCellAt(i, j)?.GetSymbol()))
                {
                    hasWon = false;
                    break;
                }
            }

            if (hasWon) return true;
        }

        return false;
    }
}
