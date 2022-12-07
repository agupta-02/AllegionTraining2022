using AllegionUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Drawing.Drawing2D;

namespace AllegionTraining2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver _browser= new ChromeDriver();
            _browser.Url = "https://www.selenium.dev/selenium/docs/api/dotnet/";
            Console.WriteLine(_browser.Title);
        }
    }
}
