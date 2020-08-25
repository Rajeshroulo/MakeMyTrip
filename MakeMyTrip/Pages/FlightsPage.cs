﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MakeMyTrip.Page
{
    public class FlightsPage
    {
        public IWebDriver driver;

        public FlightsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'From')]")]
        public IWebElement from;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='From']")]       
        public IWebElement fromcity;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Visakhapatnam, India')]")]
        public IWebElement vkp;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'To')]")]
        public IWebElement to;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='To']")]
        public IWebElement tocity;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Delhi, India')]")]
        public IWebElement del;
        
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Search')]")]
        public IWebElement serach;

        public void FlightBooking()
        {
            Thread.Sleep(6000);
            from.Click();
            fromcity.SendKeys("Visakhapatnam");
            Thread.Sleep(6000);
            vkp.Click();
            to.Click();          
            tocity.SendKeys("Delhi");
            Thread.Sleep(5000);
            del.Click();
            serach.Click();
            Thread.Sleep(5000);
        }
    }
}