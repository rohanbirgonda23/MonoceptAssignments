using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int total = 0;
        int turnCount = 0;

        while (total < 20)
        {
            int turnScore = 0;
            turnCount++;

            Console.WriteLine("\nTurn " + turnCount);

            while (true)
            {
                Console.Write("Press r to roll or h to hold: ");
                char ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'r')
                {
                    int dice = rand.Next(1, 7);
                    Console.WriteLine("Dice: " + dice);

                    if (dice == 1)
                    {
                        turn = 0;
                        Console.WriteLine("You lost this turn!");
                        Console.WriteLine("Turn Score: " + turnScore + " | Total Score: " + total);
                        break;
                    }

                    turnScore += dice;
                    Console.WriteLine("Turn Score: " + turnScore + " | Total Score: " + total);
                }
                else if (ch == 'h')
                {
                    total += turnScore;
                    Console.WriteLine("You held.");
                    Console.WriteLine("Turn Score: " + turnScore + " | Total Score: " + total);
                    break;
                }

                if (total >= 20) break;
            }
        }

        Console.WriteLine("\nYou reached 20 points!");
        Console.WriteLine("Total turns taken: " + turnCount);
    }
}