public class WinnerChecker
{
    public bool HasWinner(Board board, char mark)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board.GetCell(i, 0) == mark &&
                board.GetCell(i, 1) == mark &&
                board.GetCell(i, 2) == mark)
                return true;
        }

        for (int j = 0; j < 3; j++)
        {
            if (board.GetCell(0, j) == mark &&
                board.GetCell(1, j) == mark &&
                board.GetCell(2, j) == mark)
                return true;
        }

        if (board.GetCell(0, 0) == mark &&
            board.GetCell(1, 1) == mark &&
            board.GetCell(2, 2) == mark)
            return true;

        if (board.GetCell(0, 2) == mark &&
            board.GetCell(1, 1) == mark &&
            board.GetCell(2, 0) == mark)
            return true;

        return false;
    }
}