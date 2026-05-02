using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ZaitsevMS.Tyuiu.Sprint5.Task1.V0.Lib;

namespace ZaitsevMS.Tyuiu.Sprint5.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFiles()
        {
            string path = @"C:\Users\macjim\source\repos\Tyuiu.ZaitsevMS.Sprint5\ZaitsevMS.Tyuiu.Sprint5.Task1\bin\Debug\OutputFileTask1.txt";

            FileInfo fI = new FileInfo(path);
            bool fileEx = fI.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileEx);
        }
    }
}
