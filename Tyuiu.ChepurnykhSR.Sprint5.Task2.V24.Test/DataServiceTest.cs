using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChepurnykhSR.Sprint5.Task2.V24.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {

            DataService ds = new DataService();
            string path = @"C:\Users\user\source\repos\Tyuiu.ChepurnykhSR.Sprint5\Tyuiu.ChepurnykhSR.Sprint5.Task2.V24\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
