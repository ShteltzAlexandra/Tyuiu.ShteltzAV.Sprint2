using Tyuiu.ShteltzAV.Sprint2.Task3.V25.Lib;

namespace Tyuiu.ShteltzAV.Sprint2.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {

            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.5;
            Assert.AreEqual(wait, res);

        }
    }
}
