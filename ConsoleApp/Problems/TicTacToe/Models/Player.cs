using ConsoleApp.Problems.TicTacToe.Enums;

namespace ConsoleApp.Problems.TicTacToe.Models;

public class Player
{
    private string name;
    private Symbol symbol;

    public Player(string name, Symbol symbol)
    {
        this.name = name;
        this.symbol = symbol;
    }

    public string GetName() => name;
    public Symbol GetSymbol() => symbol;
}
