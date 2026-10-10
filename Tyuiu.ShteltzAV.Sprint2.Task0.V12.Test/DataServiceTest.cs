using Tyuiu.ShteltzAV.Sprint2.Task0.V12.Lib;

namespace Tyuiu.ShteltzAV.Sprint2.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperation()
        {
            DataService ds = new DataService();
            int x = 1095;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
