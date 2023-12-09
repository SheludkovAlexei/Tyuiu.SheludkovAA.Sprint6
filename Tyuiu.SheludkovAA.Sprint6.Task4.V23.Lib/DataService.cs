using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SheludkovAA.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] arr = new double[len];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 1)
                {
                    int y = 4 - 2 * i;
                    arr[index] = y;
                }
                else
                {
                    double y = Math.Round(4 - 2 * i + ((2 + Math.Cos(i)) / (2 * i - 2)), 2);
                    arr[index] = y;
                }
                index++;

            }
            return arr;
        }
    }
}
