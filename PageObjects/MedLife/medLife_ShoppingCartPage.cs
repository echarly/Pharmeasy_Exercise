using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace Pharmeasy_Exercise
{
    public class medLife_ShoppingCartPage : basePage
    {
        IWebDriver driver;
        int num;

        //Locators
        [FindsBy(How = How.XPath, Using = "//a[@class='lbgdE _32Xuq']")]
        IWebElement shoppingCartButton;

        [FindsBy(How = How.XPath, Using = "//a[@href='/health-care/devices-46']")]
        IWebElement devicesButton;
        
        [FindsBy(How = How.XPath, Using = "//a[@href='/health-wellness?src=header']")]
        IWebElement healthCareLink;

        [FindsBy(How = How.XPath, Using = "//span[@class='_3t5mc'][contains(text(), '₹')]")]
        IWebElement cartItems;

        public medLife_ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public medLife_ShoppingCartPage clickShoppingCartButton()
        {
            shoppingCartButton.Click();

            return this;
        }

    }
}
