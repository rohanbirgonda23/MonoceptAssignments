using System;

public class TicTacToeFacade
{
    private Board board;
    private PlayerManager playerManager;
    private WinnerChecker winnerChecker;
    private bool gameOver;

    public TicTacToeFacade()
    {
        board = new Board();
        playerManager = new PlayerManager();
        winnerChecker = new WinnerChecker();
        gameOver = false;
    }

    public void DisplayGame()
    {
        board.DisplayBoard();

        if (!gameOver)
        {
            Console.WriteLine("Current Player: " + playerManager.GetCurrentPlayer());
        }
    }

    public void PlayMove(int row, int col)
    {
        if (gameOver)
        {
            Console.WriteLine("Game is over. Reset to start a new game.");
            return;
        }

        char currentPlayer = playerManager.GetCurrentPlayer();

        bool success = board.PlaceMark(row, col, currentPlayer);

        if (!success)
        {
            Console.WriteLine("Invalid move. Try again.");
            return;
        }

        if (winnerChecker.HasWinner(board, currentPlayer))
        {
            board.DisplayBoard();
            Console.WriteLine("Player " + currentPlayer + " wins!");
            gameOver = true;
            return;
        }

        if (board.IsFull())
        {
            board.DisplayBoard();
            Console.WriteLine("Game is a draw!");
            gameOver = true;
            return;
        }

        playerManager.SwitchPlayer();
    }

    public void ResetGame()
    {
        board.ResetBoard();
        playerManager.ResetPlayer();
        gameOver = false;
        Console.WriteLine("Game reset successfully.");
    }
}