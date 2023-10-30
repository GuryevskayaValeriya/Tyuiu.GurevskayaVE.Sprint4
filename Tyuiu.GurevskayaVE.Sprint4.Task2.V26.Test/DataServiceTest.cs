using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint4.Task2.V26.Lib;

namespace Tyuiu.GurevskayaVE.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check222()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4 };
            int res = ds.Calculate(array);
            int wait = 315;
            Assert.AreEqual(wait, res);

        }
    }
}
