using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint4.Task6.V6.Lib;

namespace Tyuiu.ElizarovKI.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] array =  { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Борис", "Ирина" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
