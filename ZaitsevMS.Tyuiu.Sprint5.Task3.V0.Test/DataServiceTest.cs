using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task3.V30.Lib;
 
namespace ZaitsevMS.Tyuiu.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            ds.SaveToFileTextData(3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            bool fEx = File.Exists(path);

            bool wait = true;
            Assert.AreEqual(wait, fEx);
        }
    }
}