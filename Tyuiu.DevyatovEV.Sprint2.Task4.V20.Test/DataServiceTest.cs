﻿using Tyuiu.DevyatovEV.Sprint2.Task4.V20.Lib;

namespace Tyuiu.DevyatovEV.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 32;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 0.833;
            Assert.AreEqual(wait, res);
        }
    }
}