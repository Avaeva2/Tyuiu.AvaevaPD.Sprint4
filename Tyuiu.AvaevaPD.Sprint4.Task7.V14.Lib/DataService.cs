using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AvaevaPD.Sprint4.Task7.V14.Lib
{
    public class DataService : ISprint4Task7V14




    {
        public int Calculate(int n, int m, string value)
        {
            string digits = "458712659137";
            int[,] mtrx = new int[n, m];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int digit = int.Parse(digits.Substring(i, 1));
                }
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for ( int j = 0; j < m; j++)
                {
                    if (mtrx[i,j]==0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
