using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint4.Task5.V9.Lib;

namespace Tyuiu.GurevskayaVE.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check6()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { -4, -3, -2, -1, 0 }, { 1, 2, 3, 4, 0 }, { -4, -3, -2, -1, 0 }, { 1, 2, 3, 4, 0 }, { -4, -3, -2, -1, 0 } };
            int res = ds.Calculate(mas);
            int wait = 8;

            Assert.AreEqual(wait, res);
        }
    }
}
