using System;
using Tyuiu.ShteltzAV.Sprint2.Task6.V5.Lib;

namespace Tyuiu.ShteltzAV.Sprint2.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Штельц А. В. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Штельц Александра Владимировна | ПИНб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданному номеру карты k (6 <= k <= 14) определить достоинство       *");
            Console.WriteLine("* соответствующей карты.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер карты (от 6 до 14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((k < 6) || (k > 14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Достоинство карты: " + ds.FindCardValue(k);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}