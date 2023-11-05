using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint4.Task2.V8.Lib;

namespace Tyuiu.FalinGS.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

            int res = ds.Calculate(numsArray);
            int wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}
