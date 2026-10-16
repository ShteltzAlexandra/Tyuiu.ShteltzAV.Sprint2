using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShteltzAV.Sprint2.Task4.V29.Lib;

namespace Tyuiu.ShteltzAV.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 20;

            double res = ds.Calculate(x, y);
            double wait = 240.0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateConditionFalse()
        {
            DataService ds = new DataService();

            double x = 10;
            double y = 2;

            double res = ds.Calculate(x, y);
            double wait = 99.0;

            Assert.AreEqual(wait, res);
        }
    }
}
