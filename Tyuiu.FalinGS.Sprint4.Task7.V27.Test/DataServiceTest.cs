using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint4.Task7.V27.Lib;

namespace Tyuiu.FalinGS.Sprint4.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "583197256891";
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
