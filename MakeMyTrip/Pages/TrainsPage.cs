using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MakeMyTrip.Page
{
    public class TrainsPage
    {

        public IWebDriver driver;

        public TrainsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//nav//li[5]//a[1]//span[1]")]
        public IWebElement trains;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'From')]")]
        public IWebElement from;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='From']")]
        public IWebElement fromcity;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Ichchpuram Railway Station')]")]
        public IWebElement ipm;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'To')]")]
        public IWebElement to;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='To']")]
        public IWebElement tocity;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'New Delhi Railway Station')]")]
        public IWebElement del;
      
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Search')]")]
        public IWebElement search;

        public void FindTrains()
        {
            Thread.Sleep(5000);
            trains.Click();
            Thread.Sleep(4000);
            string mainWindow = driver.CurrentWindowHandle;
            from.Click();
            fromcity.SendKeys("Ichapuram");
            Thread.Sleep(5000);
            ipm.Click();
            to.Click();
            driver.SwitchTo().Window(mainWindow);
            tocity.SendKeys("Delhi");
            Thread.Sleep(4000);
            del.Click();
            search.Click();
            Thread.Sleep(3000);
        }    
    }
}
