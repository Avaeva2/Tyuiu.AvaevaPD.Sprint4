using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint4.Task2.V4.Lib;
namespace Tyuiu.AvaevaPD.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 3, 4, 5, 6, 7, 8, 9, 4, 5, 6, 8 };

            int res = ds.Calculate(numsArray);
            int wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}
