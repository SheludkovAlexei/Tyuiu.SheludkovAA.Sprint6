using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SheludkovAA.Sprint6.Task2.V6.Lib
{
    public class DataService : ISprint6Task2V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] arr = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x))/(x-0.7)-(Math.Sin(x)*12*x)+2, 2);
                arr[cnt] = y;
                cnt++;
            }
            return arr;
        }
    }
}
