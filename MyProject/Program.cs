using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию (+, -, *, /, ^2):");
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Введите второе число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    break;
                case "-":
                    Console.WriteLine("Введите второе число:");
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num3;
                    break;
                case "*":
                    Console.WriteLine("Введите второе число:");
                    double num4 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num4;
                    break;
                case "/":
                    Console.WriteLine("Введите второе число:");
                    double num5 = Convert.ToDouble(Console.ReadLine());
                    if (num5 != 0)
                    {
                        result = num1 / num5;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        return;
                    }
                    break;
                case "^2":
                    result = num1 * num1;
                    break;
                default:
                    Console.WriteLine("Неверная операция");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
