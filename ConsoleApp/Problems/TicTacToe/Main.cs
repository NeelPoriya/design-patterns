using ConsoleApp.Problems.TicTacToe.Models;

namespace ConsoleApp.Problems.TicTacToe;

public class Main
{
    public static void main()
    {
        int rows = 3, cols = 3;
        Player player1 = new Player("Neel", Enums.Symbol.X);
        Player player2 = new Player("Aryan", Enums.Symbol.O);
        Game game = new Game(rows, cols, player1, player2);

        while (!game.IsGameOver())
        {
            game.GetBoard().PrintBoard();
            Console.Write($"\n\n{game.GetCurrentPlayer().GetName()} ({game.GetCurrentPlayer().GetSymbol().ToString()}) | Enter a number between (1, {rows * cols}) : ");
            string? input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                int i = (number - 1) / rows;
                int j = (number - 1) % cols;

                game.MakeMove(i, j);
            }
            else
            {
                Console.WriteLine($"Please give me a valid number!");
            }
        }
    }
}
