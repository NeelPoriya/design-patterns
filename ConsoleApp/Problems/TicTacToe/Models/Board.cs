using System.Globalization;
using ConsoleApp.Problems.TicTacToe.Enums;

namespace ConsoleApp.Problems.TicTacToe.Models;

public class Board
{
    private List<List<Cell>> board = [];
    private int rows;
    private int cols;

    public Board(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        for (int i = 0; i < rows; ++i)
        {
            List<Cell> row = new List<Cell>();
            for (int j = 0; j < cols; ++j)
            {
                row.Add(new Cell($"{i}{j}"));
            }
            board.Add(row);
        }
    }

    public void Clear()
    {
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                board[i][j].SetSymbol(Symbol.EMPTY);
            }
        }
    }

    public bool IsCellAvailableAt(int row, int col)
    {
        return !(!IsCellValid(row, col) || !Equals(board[row][col].GetSymbol(), Symbol.EMPTY));
    }

    public void SetCell(int row, int col, Symbol symbol)
    {
        if (!IsCellValid(row, col))
        {
            Console.WriteLine($"Invalid cell ({row}, {col})");
            return;
        }

        board[row][col].SetSymbol(symbol);
    }

    public bool IsAnyCellEmpty()
    {
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                if (Equals(board[i][j].GetSymbol(), Symbol.EMPTY)) return true;
            }
        }
        return false;
    }

    private bool IsCellValid(int row, int col)
    {
        return !(row < 0 || row >= rows || col < 0 || col >= cols);
    }

    public int GetRows() => rows;
    public int GetCols() => cols;
    public Cell? GetCellAt(int row, int col)
    {
        if (!IsCellValid(row, col)) return null;
        return board[row][col];
    }

    public void PrintBoard()
    {
        Console.Clear();
        for (int i = 0; i < rows; ++i)
        {
            Console.WriteLine("   |   |   ");
            for (int j = 0; j < cols; ++j)
            {
                string currentSymbol = board[i][j].GetSymbol() == Symbol.EMPTY ? (i * rows + j + 1).ToString() : board[i][j].GetSymbol().ToString();
                Console.Write($" {currentSymbol} ");
                if (j != cols - 1) Console.Write("|");
            }
            Console.WriteLine("\n   |   |   ");
            if (i != rows - 1)
            {
                Console.WriteLine("-----------");
            }
        }
    }
}
