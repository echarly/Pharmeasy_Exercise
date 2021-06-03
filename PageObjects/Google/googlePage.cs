using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Pharmeasy_Exercise
{
    public class googlePage : basePage
    {
        IWebDriver driver;

        //Locators
        [FindsBy(How = How.XPath, Using = "//input[@title='Buscar']")]
        IWebElement googleSearchText;

        [FindsBy(How = How.XPath, Using = "//div[@class='FPdoLc lJ9FBc']//input[@value='Buscar con Google']")]
        IWebElement googleSearchButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='yuRUbf']//a")]
        public IWebElement medLifeLink;

        public googlePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public googlePage openGoogle()
        {
            googleSearchText.SendKeys("https://www.medlife.com/");
            googleSearchText.SendKeys(Keys.Tab);
            googleSearchButton.Click();

            return this;
        }

        public googlePage clickGoogleSearchResults()
        {
            medLifeLink.Click();

            return this;
        }
    }
}
