using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint4.Task4.V12.Lib;

namespace Tyuiu.GurevskayaVE.Sprint4.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check5()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { 3,6,6,8,8, },
                                         { 2,7,2,4,6 }, 
                                         { 3,6,2,6,4 }, 
                                         { 8,6,2,7,3 }, 
                                         { 8,7,6,6,6 } };
            int[,] res = ds.Calculate(mas);
            int[,] wait = { { 3,1,1,1,1, },
                            { 1,7,1,1,1 },
                            { 3,1,1,1,1 },
                            { 1,1,1,7,3 },
                            { 1,7,1,1,1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
