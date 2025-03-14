using System;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers);
            Console.WriteLine($"Średnia: {average}");
        }

        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; // Zwróć 0, jeśli tablica jest pusta
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}


