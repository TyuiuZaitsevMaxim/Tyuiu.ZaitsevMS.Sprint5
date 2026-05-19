using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task1.V4.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task1.V4.Test
{ 
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            ds.SaveToFileTextData(-5, 5);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            bool fEx = File.Exists(path);

            bool wait = true;
            Assert.AreEqual(wait, fEx);
        }
    }
}