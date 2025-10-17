using Tyuiu.DevyatovEV.Sprint2.Task2.V4.Lib;

namespace Tyuiu.DevyatovEV.Sprint2.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 8;
            int y = 10;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}