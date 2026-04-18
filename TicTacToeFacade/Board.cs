using System;

public class Board
{
    private char[,] grid = new char[3, 3];

    public Board()
    {
        ResetBoard();
    }

    public bool PlaceMark(int row, int col, char mark)
    {
        if (row < 0 || row > 2 || col < 0 || col > 2)
            return false;

        if (grid[row, col] != ' ')
            return false;

        grid[row, col] = mark;
        return true;
    }

    public char GetCell(int row, int col)
    {
        return grid[row, col];
    }

    public bool IsFull()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grid[i, j] == ' ')
                    return false;
            }
        }
        return true;
    }

    public void ResetBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                grid[i, j] = ' ';
            }
        }
    }

    public void DisplayBoard()
    {
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.Write(" ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(grid[i, j]);
                if (j < 2)
                    Console.Write(" | ");
            }

            Console.WriteLine();

            if (i < 2)
                Console.WriteLine("---|---|---");
        }

        Console.WriteLine();
    }
}