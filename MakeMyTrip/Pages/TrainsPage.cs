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
        public IWebElement fromCity;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Ichchpuram Railway Station')]")]
        public IWebElement ichapuram; 

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'To')]")]
        public IWebElement to;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='To']")]
        public IWebElement toCity;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'New Delhi Railway Station')]")]
        public IWebElement delhi; 
      
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Search')]")]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//span[text()='rajraval017@gmail.com']")]
        public IWebElement mail;

        public void FindTrains()
        {
            Thread.Sleep(5000);
            trains.Click();
            Thread.Sleep(4000);
            string mainWindow = driver.CurrentWindowHandle;
            from.Click();
            fromCity.SendKeys("Ichapuram");
            Thread.Sleep(5000);
            ichapuram.Click();
            to.Click();
            driver.SwitchTo().Window(mainWindow);
            toCity.SendKeys("Delhi");
            Thread.Sleep(4000);
            delhi.Click();
            search.Click();
            Thread.Sleep(5000);
        } 
        
        public string MailId()
        {
            return mail.Text;
        }
    }
}
