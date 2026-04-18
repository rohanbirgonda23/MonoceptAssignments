using System;

class Program
{
    static void Main()
    {
        TicTacToeFacade game = new TicTacToeFacade();

        while (true)
        {
            game.DisplayGame();

            Console.WriteLine("Enter row and column (0 to 2) separated by space");
            Console.WriteLine("Type reset to start again or exit to quit");

            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (input.ToLower() == "reset")
            {
                game.ResetGame();
                continue;
            }

            string[] parts = input.Split(' ');

            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            bool validRow = int.TryParse(parts[0], out int row);
            bool validCol = int.TryParse(parts[1], out int col);

            if (!validRow || !validCol)
            {
                Console.WriteLine("Please enter numbers only.");
                continue;
            }

            game.PlayMove(row, col);
        }
    }
}