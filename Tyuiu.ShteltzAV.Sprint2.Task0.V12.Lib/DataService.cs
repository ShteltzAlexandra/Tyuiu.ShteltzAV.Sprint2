using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShteltzAV.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 620 == y;
            res[1] = x - 620 != y;
            res[2] = x - 630 < y;
            res[3] = x - 621 > y;
            res[4] = x - 630 <= y;
            res[5] = x - 630 >= y;

            return res;
        }
    }
}
