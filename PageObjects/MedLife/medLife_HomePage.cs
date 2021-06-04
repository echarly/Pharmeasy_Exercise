using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace Pharmeasy_Exercise
{
    public class medLife_HomePage : basePage
    {
        IWebDriver driver;

        //Locators
        [FindsBy(How = How.XPath, Using = "//div[@class='row']/div/a")]
        IWebElement medLifeBanner;

        [FindsBy(How = How.Id, Using = "wiz-iframe-intent")]
        IWebElement welcomeBanner;
        
        [FindsBy(How = How.XPath, Using = "//a[@href='/health-wellness?src=header']")]
        IWebElement healthCareLink;

        [FindsBy(How = How.XPath, Using = "//a[@href='/health-care/devices-46']")]
        IWebElement devicesButton;



        public medLife_HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public medLife_HomePage medLifeSearch()
        {

            medLifeBanner.Click();

            //Handle Welcome banner
            handleWelcomeBanner();

            //Wait Time
            WaitTime(healthCareLink);
            healthCareLink.Click();

            //Wait Time
            WaitTime(devicesButton);

            devicesButton.Click();

            return this;
        }

        public medLife_HomePage handleWelcomeBanner()
        {
            try
            {
                WaitTime(welcomeBanner);
                welcomeBanner.Click();
            }
            catch (Exception e)
            {
                //  Block of code to handle errors
                Console.WriteLine("Welcome banner is not displayed");
            }

            return this;
        }
    }
}
