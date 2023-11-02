﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint4.Task3.V29.Lib;

namespace Tyuiu.GurevskayaVE.Sprint4.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void Check3()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5,5] { { 9, 9, 8, 6, 9 }, { 5, 8, 8, 8, 7 }, { 6, 5, 9, 7, 9 }, { 7, 7, 9, 7, 8 }, { 8, 5, 8, 5, 5 } };
            int res = ds.Calculate(mas);
            int wait = 15120;

            Assert.AreEqual(wait, res);
        }
    }
}
