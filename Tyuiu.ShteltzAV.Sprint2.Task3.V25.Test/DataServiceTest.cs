using Tyuiu.ShteltsAV.Sprint2.Task3.V25.Lib;

namespace Tyuiu.ShteltsAV.Sprint2.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFunctionValues()
        {
            DataService ds = new DataService();

            Assert.AreEqual(9.989, ds.Calculate(2));
            Assert.AreEqual(0.333, ds.Calculate(0));
            Assert.AreEqual(0.64, ds.Calculate(-2));
            Assert.AreEqual(-3.0, ds.Calculate(-30));
        }
    }
}
