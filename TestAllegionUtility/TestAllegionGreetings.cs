using AllegionUtility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAllegionUtility
{
    [TestClass]
    public class TestAllegionGreetings
    {
        Greetings testob = new Greetings();

        [TestMethod]
        public void SayHelloQATest()
        {
            string str1 = "Welcome to QA";
            Assert.AreEqual(str1, testob.SayHelloQA());
        }

        [TestMethod]
        public void SayHelloDevTest()
        {
            string str1 = "Welcome to Development";
            Assert.AreEqual(str1, testob.SayHelloDev());
        }
    }
}
