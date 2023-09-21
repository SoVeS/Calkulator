using System;

namespace Calkulator
{
    class Program
    {
        static void Main()
        {
            int choice;
            double num1, num2;

            do

            {
                Console.WriteLine("Что хотите сделать?");
                Console.WriteLine("1-Сложить");
                Console.WriteLine("2-Вычесть");
                Console.WriteLine("3-Умножить");
                Console.WriteLine("4-Разделить");
                Console.WriteLine("5-Возвести в степень");
                Console.WriteLine("6-Найти квадратный корень");
                Console.WriteLine("7-Найти 1 процент от числа");
                Console.WriteLine("8-Найти факториал");
                Console.WriteLine("9-Выйти из калькулятора");

                choice = Convert.ToInt16(Console.ReadLine());

                if (choice == 1)

                {
                    Console.WriteLine("Введите 1 число");
                    num1 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Введите 2 число");
                    num2 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Результат сложения =" + (num1 + num2));
                }


                else if (choice == 2)
                {
                    Console.WriteLine("Введите 1 число");
                    num1 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Введите 2 число");
                    num2 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Результат вычитания =" + (num1 + num2));
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Введите 1 число");
                    num1 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Введите 2 число");
                    num2 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Результат умножения =" + (num1 * num2));
                }

                else if (choice == 4)
                {
                    Console.WriteLine("Введите 1 число");
                    num1 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Введите 2 число");
                    num2 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Результат деления =" + (num1 / num2));
                }

                else if (choice == 5)
                {
                    Console.WriteLine("Введите 1 число");
                    num1 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Введите степень числа");
                    num2 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Результат возведения в степень =" + Math.Pow(num1, num2));
                }

                else if (choice == 6)
                {
                    Console.WriteLine("Введите число");
                    num1 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Результат квадратного корня =" + Math.Sqrt(num1));
                }

                else if (choice == 7)
                {
                    Console.WriteLine("Введите число");
                    num1 = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("1 процент от " + (num1) + " = " + (num1 / 100));
                }

                else if (choice == 8)
                {
                    Console.WriteLine("Введите число");
                    num1 = Convert.ToDouble(Console.ReadLine());


                    int factorial = 1;
                    for (int i = 1; i <= num1; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Факториал " + (num1) + " это: " + (factorial));
                }

                else if ((choice <= 0) | (choice >= 10))

                    Console.WriteLine("Неверно");


            }
            while (choice != 9);
            Console.WriteLine("Конец");
            
        }
    }
}
