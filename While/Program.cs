using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть натуральне число n: ");
        int n = int.Parse(Console.ReadLine());

        double resultA = CalculateA(n);
        double resultB = CalculateB(n);
        double resultC = CalculateC(n);

        Console.WriteLine($"Результат A: {resultA}");
        Console.WriteLine($"Результат B: {resultB}");
        Console.WriteLine($"Результат C: {resultC}");
    }

    static double CalculateA(int n)
    {
        double sum = 0;
        int i = 0;

        while (i < n)
        {
            sum += (i % 2 == 0 ? 1 : -1) / (double)(2 * i + 3);   
            i++;
        }

        return sum;
    }

    static double CalculateB(int n)
    {
        double sum = 0;
        int i = 1;

        while (i <= n)
        {
            sum += 1.0 / (1 + (i * i) * 12);   
            i++;
        }

        return sum;
    }

    static double CalculateC(int n)
    {
        double sum = 0;
        int i = 1;

        while (i <= n)
        {
            sum += Factorial(i);  
            i++;
        }

        return sum;
    }

    static double Factorial(int num)
    {
        double fact = 1;
        int i = 1;

        while (i <= num)
        {
            fact *= i;
            i++;
        }

        return fact;
    }
}