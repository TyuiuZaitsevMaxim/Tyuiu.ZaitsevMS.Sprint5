using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task5.V17.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void CheckedSumPrimes()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V17.txt");
            File.WriteAllText(path, "-9 13 -0.71 19.24 2.73 -0.5 -8 12.8 -3.01 11.69 -7 -1 11.8 7 -4 5.33 18.96 12.16 -5 -8.15");

            double res = ds.LoadFromDataFile(path);

            double wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}