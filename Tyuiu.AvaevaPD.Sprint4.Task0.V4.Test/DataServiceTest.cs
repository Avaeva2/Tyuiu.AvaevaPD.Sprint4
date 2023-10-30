using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint4.Task0.V4.Lib;
namespace Tyuiu.AvaevaPD.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int expectedResult = CalculateEvenProduct(numsArray);
            
            int CalculateEvenProduct(int[] array)
            {
                int product = 1;
                foreach (int number in array)
                {
                    if (number % 2 == 0)
                    {
                        product *= number;
                    }
                }
               
                return product;
            }
        }
    }
}
