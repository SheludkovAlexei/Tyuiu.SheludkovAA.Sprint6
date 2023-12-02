using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint6.Task3.V3.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtr = new int[2, 2] { { 1,2 },
                                         { 2,1 }};
            int[,] res = ds.Calculate(mtr);
            int[,] wait = new int[2, 2] { { 1,1 },
                                          { 2,2 }};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
