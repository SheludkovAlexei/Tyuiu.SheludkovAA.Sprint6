using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SheludkovAA.Sprint6.Task3.V3.Lib
{
    public class DataService : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int coll = matrix.Length / rows;
            int[] sp = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (j == 1)
                    {
                        sp[i] = matrix[i, j];
                        
                    }
                }
            }
            Array.Sort(sp);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (j == 1)
                    {
                        matrix[i, j] = sp[i];

                    }
                }
            }
            return matrix;
        }
    }
}
