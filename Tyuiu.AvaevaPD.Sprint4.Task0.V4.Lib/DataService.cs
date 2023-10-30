using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AvaevaPD.Sprint4.Task0.V4.Lib
{
    public class DataService : ISprint4Task0V4

    {
        public int GetMultEvenArrEl(int[] array)
        {
            int[] arr = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            int evenProducts = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenProducts *= array[i];
                }
            }
            Console.WriteLine("Произведение четных элементов: " + evenProducts);
            return evenProducts;
        }
    }
}
