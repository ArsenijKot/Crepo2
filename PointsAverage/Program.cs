using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double[] grades = new double[5];
        double sum = 0;

       
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Введіть оцінку {i + 1}: ");
            grades[i] = Convert.ToDouble(Console.ReadLine());

            
            if (grades[i] < 0 || grades[i] > 100)
            {
                Console.WriteLine("Оцінка повинна бути в межах від 0 до 100. Спробуйте ще раз.");
                i--; 
            }
            else
            {
                sum += grades[i]; 
            }
        }

        double average = sum / 5;

        Console.WriteLine($"Середній бал студента: {average}");

        if (average >= 50)
        {
            Console.WriteLine("Студент допущений до екзамену.");
        }
        else
        {
            Console.WriteLine("Студент не допущений до екзамену.");
        }
    }
}
