using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace Pharmeasy_Exercise
{
    public class basePage
    {

        static public IWebDriver driver;

        //URL
        string url = "https://www.google.com/";

        #region Methods
        public basePage InitializeChromeDriver()
        {
            driver = new ChromeDriver("C:\\Chromedriver\\");

            return this;
        }

        public basePage InitializeFireFoxDriver()
        {
            driver = new FirefoxDriver("C:\\Firefoxdriver\\");

            return this;
        }

        public basePage OpenBrowser()
        {
            driver.Url = url;
            Console.WriteLine("URL: " + url);

            return this;
        }

        public basePage WaitTime(IWebElement element)
        {
            //-----Impicit
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //-----Explicit
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(driver => element.Displayed);


            return this;
        }

        public basePage closeDriver()
        {
            driver.Quit();

            return this;
        }
        #endregion
    }
}
