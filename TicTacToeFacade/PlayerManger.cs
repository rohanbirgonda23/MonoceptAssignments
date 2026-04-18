public class PlayerManager
{
    private char currentPlayer;

    public PlayerManager()
    {
        currentPlayer = 'X';
    }

    public char GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public void SwitchPlayer()
    {
        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
    }

    public void ResetPlayer()
    {
        currentPlayer = 'X';
    }
}