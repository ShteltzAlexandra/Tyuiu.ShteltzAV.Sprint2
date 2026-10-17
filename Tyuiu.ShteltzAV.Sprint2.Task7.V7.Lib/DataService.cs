using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShteltzAV.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ((y >= 0) && (y >= x) && (y <= 2 - Math.Pow(x, 2)) || (y >= 0) && (y <= x) && (y <= 2 - Math.Pow(x,2)) || (y <= 0) && (y >= x) && (y <= 2 - Math.Pow(x, 2)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}