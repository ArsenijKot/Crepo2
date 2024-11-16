using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть число від 0 до 9: ");
        int number = Convert.ToInt32(Console.ReadLine());

        
        if (number < 0 || number > 9)
        {
            Console.WriteLine("Число повинно бути в діапазоні від 0 до 9.");
        }
        else
        {
            
            switch (number)
            {
                case 0:
                    Console.WriteLine("нуль");
                    break;
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("чотири");
                    break;
                case 5:
                    Console.WriteLine("п'ять");
                    break;
                case 6:
                    Console.WriteLine("шість");
                    break;
                case 7:
                    Console.WriteLine("сім");
                    break;
                case 8:
                    Console.WriteLine("вісім");
                    break;
                case 9:
                    Console.WriteLine("дев'ять");
                    break;
                default:
                    Console.WriteLine("Невірне число.");
                    break;
            }
        }
    }
}

