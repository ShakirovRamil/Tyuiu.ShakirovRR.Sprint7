using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShakirovRR.Sprint7.Project.V7.Lib;

namespace Tyuiu.ShakirovRR.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {

        DataService ds = new DataService();

        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint7\file\file.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
