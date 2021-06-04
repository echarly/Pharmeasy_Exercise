using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace Pharmeasy_Exercise
{
    public class medLife_HealthCareProductsPage : basePage
    {
        IWebDriver driver;

        //Locators
        [FindsBy(How = How.XPath, Using = "//div[@class='row']/div/a")]
        IWebElement medLifeBanner;

        [FindsBy(How = How.XPath, Using = "//a[@href='/health-care/devices-46']")]
        IWebElement devicesButton;
        
        [FindsBy(How = How.XPath, Using = "//a[@href='/health-wellness?src=header']")]
        IWebElement healthCareLink;



        public medLife_HealthCareProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public medLife_HealthCareProductsPage clickHealthCareLink()
        {
            devicesButton.Click();

            return this;
        }

    }
}
