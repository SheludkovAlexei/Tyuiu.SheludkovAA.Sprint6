using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = -1;
            int e = 1;
            double[] arr = new double[3];
            arr[0] = -8.42;
            arr[1] = 0.57;
            arr[2] = -6.30;
            double[] wait = ds.GetMassFunction(s, e);
            CollectionAssert.AreEqual(wait, arr);
        }
    }
}
