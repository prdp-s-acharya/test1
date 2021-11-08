using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MsbuildAndTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var moq = new Mock<Employee>();
            moq.Setup(o => o.Name).Returns("Pradeep");
            moq.Setup(o => o.Address).Returns("abcdef");
            //Console.WriteLine(moq.Object.Name);
            //Console.WriteLine(moq.Object.Address);
            Assert.AreEqual("Pradeep", moq.Object.Name);
            Assert.AreEqual("abcdef", moq.Object.Address);
        }
    }
}
