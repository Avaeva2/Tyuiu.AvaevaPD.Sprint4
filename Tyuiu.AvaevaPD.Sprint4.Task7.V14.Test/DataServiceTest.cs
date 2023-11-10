using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint4.Task7.V14.Lib;
namespace Tyuiu.AvaevaPD.Sprint4.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string digits = "458712659137";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, digits);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
