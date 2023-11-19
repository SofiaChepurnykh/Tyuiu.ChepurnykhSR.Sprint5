using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChepurnykhSR.Sprint5.Task0.V17.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint5.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.ChepurnykhSR.Sprint5\Tyuiu.ChepurnykhSR.Sprint5.Task0.V17\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
