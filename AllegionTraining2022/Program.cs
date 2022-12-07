using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace AllegionTraining2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RemoteWebDriver _browser = new RemoteWebDriver(new Uri("http://localhost:9515"), new ChromeOptions());
            //_browser.Url = "https://the-internet.herokuapp.com/";
            //Console.WriteLine(_browser.Title);
            //IWebElement headingElement = _browser.FindElementByTagName("h1");
            //String actualHeadingText = headingElement.Text;
            //Console.WriteLine(actualHeadingText);

            //ChromeDriver _browser = new ChromeDriver();
            //_browser.Url = "https://the-internet.herokuapp.com/";
            //Console.WriteLine(_browser.Title);
            //IWebElement headingElement = _browser.FindElement(By.TagName("h1"));
            //String actualHeadingText = headingElement.Text;
            //Console.WriteLine(actualHeadingText);

            EdgeDriver _browser = new EdgeDriver();
            _browser.Url = "https://the-internet.herokuapp.com/";
            Console.WriteLine(_browser.Title);
            IWebElement headingElement = _browser.FindElement(By.TagName("h1"));
            String actualHeadingText = headingElement.Text;
            Console.WriteLine(actualHeadingText);

            if (actualHeadingText == "Welcome to the-internet")
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            _browser.Close();
        }
    }
}
