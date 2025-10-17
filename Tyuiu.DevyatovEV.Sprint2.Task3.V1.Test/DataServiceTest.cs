using Tyuiu.DevyatovEV.Sprint2.Task3.V1.Lib;
namespace Tyuiu.DevyatovEV.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(88.697, ds.Calculate(5));
            Assert.AreEqual(9.5, ds.Calculate(2));
            Assert.AreEqual(10, ds.Calculate(1));
            Assert.AreEqual(-65.995, ds.Calculate(-6));
        }
    }
}
