using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint2.Task4.V18.Lib;

namespace Tyuiu.HubulovaVI.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;

            double res = ds.Calculate(x, y);
            double wait = 31.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 6;

            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}