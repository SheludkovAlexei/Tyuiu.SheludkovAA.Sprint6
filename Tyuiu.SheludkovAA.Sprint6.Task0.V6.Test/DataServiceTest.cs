using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint6.Task0.V6.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            double wait = 0.707;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
