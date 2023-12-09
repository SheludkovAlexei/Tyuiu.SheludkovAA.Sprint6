using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = 0;
            int e = 1;
            double[] res = ds.GetMassFunction(s, e);
            double[] wait = new double[2];
            wait[0] = 2.5;
            wait[1] = 2;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
