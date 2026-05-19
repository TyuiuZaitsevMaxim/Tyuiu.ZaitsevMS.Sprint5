using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using ZaitsevMS.Tyuiu.Sprint5.Task6.V1.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task6.V1.Test
{ 
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V1.txt");
            File.WriteAllText(path, "123 Привет, это тестовая строка 456.", Encoding.UTF8);

            int res = ds.LoadFromDataFile(path);

            int wait = 6;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V1.txt");
            File.WriteAllText(path, "123 Привет, это тестовая строка 456.", Encoding.UTF8);

            bool fEx = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(wait, fEx);
        }
    }
}