using System;
using Tyuiu.ShteltzAV.Sprint2.Task5.V2.Lib;

namespace Tyuiu.ShteltzAV.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Штельц А. В. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Штельц Александра Владимировна | ПИНб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По данному месяцу определите, в какую пору года попадает этот месяц     *");
            Console.WriteLine("* (Зима, Лето, Весна, Осень).                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (от 1 до 12): ");
            string? input = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (!int.TryParse(input, out int monthNum))
            {
                Console.WriteLine("Ошибка: введены некорректные данные! Ожидается целое число.");
            }
            else
            {
                try
                {
                    string season = ds.FindMonthSeason(monthNum);
                    Console.WriteLine($"Пора года: {season}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
