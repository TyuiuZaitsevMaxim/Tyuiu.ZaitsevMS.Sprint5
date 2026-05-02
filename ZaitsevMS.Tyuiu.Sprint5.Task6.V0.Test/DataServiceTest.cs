using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task6.V0.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\macjim\source\repos\Tyuiu.ZaitsevMS.Sprint5\ZaitsevMS.Tyuiu.Sprint5.Task6.V0\bin\Debug\InputFileTask6.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\macjim\source\repos\Tyuiu.ZaitsevMS.Sprint5\ZaitsevMS.Tyuiu.Sprint5.Task6.V0\bin\Debug\InputFileTask6.txt";

            FileInfo fI = new FileInfo(path);
            bool fEx = fI.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fEx);
        }
    }
}
