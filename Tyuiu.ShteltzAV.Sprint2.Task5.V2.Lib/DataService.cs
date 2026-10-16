using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShteltzAV.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string res;
            switch (value)
            {
                case 12:
                case 1:
                case 2:
                    res = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    res = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    res = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    res = "Осень";
                    break;
                default:
                    throw new ArgumentException($"Введено неверное значение месяца: {value}. Номер месяца должен быть от 1 до 12.");
            }
            return res;
        }
    }
}
