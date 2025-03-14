using System;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby oddzielone spacjami:");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
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



