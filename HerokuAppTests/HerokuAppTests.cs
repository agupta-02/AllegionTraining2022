using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Linq;

namespace HerokuAppTests
{
    [TestClass]
    public class HerokuAppTests
    {
        [TestMethod]
        public void AddRemoveElementsWorkCorrectlyForOneElement()
        {
            RemoteWebDriver _remotebrowser = new RemoteWebDriver(new Uri("http://localhost:9515"),new ChromeOptions());
            _remotebrowser.Url = "https://the-internet.herokuapp.com/";

            IWebElement addRemoveElementLinkClick = _remotebrowser.FindElementByXPath("//a[text()='Add/Remove Elements']");
            addRemoveElementLinkClick.Click();

            IWebElement addRemoveElementButtonClick = _remotebrowser.FindElementByXPath("//button[text()='Add Element']");
            addRemoveElementButtonClick.Click();

            ReadOnlyCollection<IWebElement> mydeletcollection = _remotebrowser.FindElementsByXPath("//button[@class='added-manually']");
            
            Assert.AreEqual(1, mydeletcollection.Count);
        }

        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 3)]
        public void AddRemoveElementsWorkCorrectlyForDataDrivenElement(int noOfClicks, int expected)
        {
            RemoteWebDriver _remotebrowser = new RemoteWebDriver(new Uri("http://localhost:9515"), new ChromeOptions());
            _remotebrowser.Url = "https://the-internet.herokuapp.com/";

            IWebElement addRemoveElementLinkClick = _remotebrowser.FindElementByXPath("//a[text()='Add/Remove Elements']");
            addRemoveElementLinkClick.Click();

            for (int i = 1; i <= noOfClicks; i++)
            {
                IWebElement addRemoveElementButtonClick = _remotebrowser.FindElementByXPath("//button[text()='Add Element']");
                addRemoveElementButtonClick.Click();
            }

            ReadOnlyCollection<IWebElement> mydeletcollection = _remotebrowser.FindElementsByXPath("//button[@class='added-manually']");

            Assert.AreEqual(expected, mydeletcollection.Count);
        }
    }
}
