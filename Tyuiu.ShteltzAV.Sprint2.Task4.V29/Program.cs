using System;
using Tyuiu.ShteltzAV.Sprint2.Task4.V29.Lib;

namespace Tyuiu.ShteltzAV.Sprint2.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Штельц А. В. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Штельц Александра Владимировна | ПИНб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значения   *");
            Console.WriteLine("* переменных x, y с клавиатуры: если x - 3 < y + 2 - 20,                  *");
            Console.WriteLine("* то z = 2x + 12y - (2/x), иначе z = x^2 - (2/y).                        *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (x == 0 || y == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно!");
            }
            else
            {
                double res = ds.Calculate(x, y);
                Console.WriteLine("Значение z = " + res);
            }

            Console.ReadKey();
        }
    }
}