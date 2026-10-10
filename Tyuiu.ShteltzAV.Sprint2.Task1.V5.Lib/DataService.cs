using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShteltzAV.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a > b) & (c < d);
            res[2] = (a > b) || (c + 10 < d);
            res[3] = (a + 2 > b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a < b) ^ (c + 10 > d);

            return res;

        }
    }
}
