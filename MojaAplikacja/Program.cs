using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj swoje imię: ");
        string name = Console.ReadLine();
        Console.WriteLine("Witaj, " + name + "!");

        Console.Write("Podaj pierwszą liczbę: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;

        Console.WriteLine("Suma tych liczb wynosi: " + sum);

        if (sum > 10)
        {
            Console.WriteLine("Suma jest większa niż 10!");
        }
        else
        {
            Console.WriteLine("Suma jest mniejsza lub równa 10.");
        }
    }
}

