using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Pharmeasy_Exercise
{
    public class basePage
    {

        static public IWebDriver driver;

        //URL
        string url = "https://www.google.com/";

        #region Methods
        public basePage InitializeDriver()
        {
            driver = new ChromeDriver("C:\\Chromedriver\\");

            return this;
        }

        public basePage OpenBrowser()
        {
            driver.Url = url;
            Console.WriteLine("URL: " + url);

            return this;
        }

        #endregion
    }
}
