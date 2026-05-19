using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task2.V5.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3]
            {
                { 9, 6, 6 },
                { 8, 7, 2 },
                { 1, 7, 8 }
            };

            ds.SaveToFileTextData(mtrx);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            bool fEx = File.Exists(path);

            bool wait = true;
            Assert.AreEqual(wait, fEx);
        }
    }
}