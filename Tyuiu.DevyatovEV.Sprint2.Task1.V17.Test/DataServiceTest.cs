using Tyuiu.DevyatovEV.Sprint2.Task1.V17.Lib;
namespace Tyuiu.DevyatovEV.Sprint2.Task1.V17.Test
{
        [TestClass]
        public sealed class DataServiceTest
        {
            [TestMethod]
            public void ValidGetLogicOperations()
            {
                DataService ds = new DataService();
                int a = 73;
                int b = 67;
                int c = 213;
                int d = 123;
                bool[] res = new bool[6];
                res = ds.GetLogicOperations(a, b, c, d);
                bool[] wait = new bool[6] { true, false, true, true, true, false };

                CollectionAssert.AreEqual(wait, res);
            }
        }
}
