using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChepurnykhSR.Sprint5.Task7.V15.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint5.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }

        [TestMethod]
        public void OutPutFileExists()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.ChepurnykhSR.Sprint5\Tyuiu.ChepurnykhSR.Sprint5.Task7.V15\bin\Debug\OutPutDataFileTask7V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.ChepurnykhSR.Sprint5\Tyuiu.ChepurnykhSR.Sprint5.Task7.V15\bin\Debug\OutPutDataFileTask7V15.txt";
            DataService dataService = new DataService();
            string outPath = dataService.LoadDataAndSave(path);
            string text = File.ReadAllText(outPath);
            Assert.AreEqual("Это  just a sample строки  English.", text);
        }
    }
}
