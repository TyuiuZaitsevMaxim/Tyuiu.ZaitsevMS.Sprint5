using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint5.Task0.V0.Lib;
using System.IO;

namespace Tyuiu.ZaitsevMS.Sprint5.Task0.V0.Test
{
    [TestClass] 
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5);
            FileInfo fI = new FileInfo(path);

            Assert.IsTrue(fI.Exists);
            Assert.AreEqual("-5", File.ReadAllText(path));
        }
    }
}

