using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        if (double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.Write("Введите второе число: ");
            if (double.TryParse(Console.ReadLine(), out double number2))
            {
                if (number1 == number2)
                {
                    Console.WriteLine("Два числа равны.");
                }
                else if (number1 > number2)
                {
                    Console.WriteLine("Первое число больше второго.");
                }
                else
                {
                    Console.WriteLine("Первое число меньше второго.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка при вводе второго числа.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка при вводе первого числа.");
        }
    }
}






