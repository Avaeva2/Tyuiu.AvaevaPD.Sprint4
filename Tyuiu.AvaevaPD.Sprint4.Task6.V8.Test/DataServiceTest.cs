using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint4.Task6.V8.Lib;
namespace Tyuiu.AvaevaPD.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var food = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            string[] res = ds.Calculate(food);
            
            int wait = 5 ;
            Assert.AreEqual(wait, res);
        }
    }
}
