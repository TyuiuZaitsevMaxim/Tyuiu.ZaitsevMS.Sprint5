using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using ZaitsevMS.Tyuiu.Sprint5.Task7.V2.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task7.V2.Test 
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string pathIn = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V2.txt");
            File.WriteAllText(pathIn, "123 Привет, это тестовая строка 456.", Encoding.UTF8);

            string pathOut = ds.LoadDataAndSave(pathIn);

            string result = File.ReadAllText(pathOut).Trim();
            string wait = "### Привет, это тестовая строка ###.";

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string pathIn = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V2.txt");
            File.WriteAllText(pathIn, "123 Привет, это тестовая строка 456.", Encoding.UTF8);

            string pathOut = ds.LoadDataAndSave(pathIn);

            bool fEx = File.Exists(pathOut);
            bool wait = true;
            Assert.AreEqual(wait, fEx);
        }
    }
}