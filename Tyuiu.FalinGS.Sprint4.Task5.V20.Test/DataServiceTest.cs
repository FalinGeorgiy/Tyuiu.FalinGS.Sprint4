using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint4.Task5.V20.Lib;

namespace Tyuiu.FalinGS.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5]{ { 1, 2, -3, -8, 1 },

                                          { 1, -7, 1, 1, 1 },

                                          { 1, 2, 0, 1, 1 },

                                          { 1, -4, 0, 3, -5 },

                                          { 2, 2, 1, 1, 2 } };

            int result = ds.Calculate(array);
            int wait = 18;
            Assert.AreEqual(wait, result);
        }
    }
}
