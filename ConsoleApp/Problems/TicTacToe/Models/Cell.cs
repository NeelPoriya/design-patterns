using ConsoleApp.Problems.TicTacToe.Enums;

namespace ConsoleApp.Problems.TicTacToe.Models;

public class Cell
{
    private string id;
    private Symbol symbol;

    public Cell(string id)
    {
        this.id = id;
        symbol = Symbol.EMPTY;
    }

    public Symbol GetSymbol() => symbol;
    public void SetSymbol(Symbol symbol) => this.symbol = symbol;
}
