using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AvaevaPD.Sprint4.Task0.V4.Lib;
namespace Tyuiu.AvaevaPD.Sprint4.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Авaева П. Д. | ИСПБ-23-1";
            // Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Аваева Полина Дмитриевна | ИСПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.  {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результурующий массив:");

            

            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
