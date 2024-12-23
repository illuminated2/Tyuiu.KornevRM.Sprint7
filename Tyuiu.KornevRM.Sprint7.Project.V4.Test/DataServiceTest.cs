using System.IO;
using Tyuiu.KornevRM.Sprint7.Project.V4.Lib;
namespace Tyuiu.KornevRM.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\iLLum\source\repos\Tyuiu.KornevRM.Sprint7\Tyuiu.KornevRM.Sprint7.Project.V4\bin\Debug\net8.0-windows\BookBase.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}