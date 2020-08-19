using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MakeMyTrip.Page
{
   public class Flights
   {

        public IWebDriver driver;

        public Flights(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'From')]")]

        public IWebElement from;

        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//div//div//div//div//div//input")]

        public IWebElement fromcity;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Visakhapatnam, India')]")]

        public IWebElement vkp;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'To')]")]

        public IWebElement to;

        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//div//div//div//div//div//input")]

        public IWebElement tocity;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Delhi, India')]")]

        public IWebElement del;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div[1]//div[3]//div[2]//div[5]")]

        public IWebElement depart;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Search')]")]

        public IWebElement serach;


        public void FlightBooking()
        {
            from.Click();
            Thread.Sleep(3000);
            fromcity.SendKeys("Visakhapatnam");
            Thread.Sleep(6000);
            vkp.Click();
            Thread.Sleep(3000);
            to.Click();
            Thread.Sleep(3000);
            tocity.SendKeys("Delhi");
            Thread.Sleep(6000);
            del.Click();
            Thread.Sleep(2000);
            depart.Click();
            Thread.Sleep(2000);
            serach.Click();
            Thread.Sleep(3000);

        }

   }
}
