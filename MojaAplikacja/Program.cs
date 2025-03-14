using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 7, 9, 2 };
        int max = FindMax(numbers);
        Console.WriteLine($"Maksymalna wartość to: {max}");
    }

    // Dodajemy metodę FindMax
    static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}




