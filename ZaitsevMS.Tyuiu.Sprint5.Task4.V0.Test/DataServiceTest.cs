using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task4.V6.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void CheckedCalculateFromFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V6.txt");
            File.WriteAllText(path, "2.24");

            double res = ds.LoadFromDataFile(path);

            double wait = 9.427;
            Assert.AreEqual(wait, res);
        }
    }
}