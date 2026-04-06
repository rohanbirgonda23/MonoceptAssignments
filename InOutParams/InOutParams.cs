using System;

class UtilityOperations
{
    public void GetValues(out int x, out int y)
    {
        x = 10;
        y = 20;
    }

    public void ShowValue(in int num)
    {
        Console.WriteLine("IN Value: " + num);
    }

    public int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}