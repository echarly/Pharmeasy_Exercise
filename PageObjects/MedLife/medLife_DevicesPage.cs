using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace Pharmeasy_Exercise
{
    public class medLife_DevicesPage : basePage
    {
        IWebDriver driver;

        //Locators
        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Popularity')]")]
        IWebElement sortButton;

        [FindsBy(How = How.XPath, Using = "//li[@data-value='price:0']")]
        IWebElement lowToHigh;

        [FindsBy(How = How.XPath, Using = "(//div[@class='_22Kwa']//a)[1]")]
        public IWebElement devicesProductOne;

        [FindsBy(How = How.XPath, Using = "(//div[@class='_22Kwa']//a)[2]")]
        public IWebElement devicesProductTwo;

        [FindsBy(How = How.XPath, Using = "(//div[@class='_22Kwa']//a)[3]")]
        public IWebElement devicesProductThree;

        [FindsBy(How = How.XPath, Using = "//div[@class='_3C1Hw']//button")]
        IWebElement addToCart;

        [FindsBy(How = How.XPath, Using = "//li[@data-value='1']")]
        IWebElement quantityButtonOne;
        

        public medLife_DevicesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Methods
        #region Methods
        public medLife_DevicesPage sortBy()
        {
            sortButton.Click();
            lowToHigh.Click();

            return this;
        }

        public medLife_DevicesPage clickProducts(IWebElement element)
        { 

            WaitTime(element);
            element.Click();
            //Wait Time

            clickAddToCart();

            //Wait Time
            WaitTime(quantityButtonOne);

            quantityButtonOne.Click();
            driver.Navigate().Back();

            return this;
        }

        public medLife_DevicesPage clickAddToCart() 
        {

            WaitTime(addToCart);
            addToCart.Click();

            return this;
        }

        #endregion Metods
    }
}
