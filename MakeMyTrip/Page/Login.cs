using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MakeMyTrip.Page
{
    public class Login
    {
        public IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
       
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/div[1]/ul/li[6]/div[3]/div/div[1]/div[2]")]

        public IWebElement google;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input")]
       
        public IWebElement gmail;

        [FindsBy(How = How.XPath, Using = "//*[@id='identifierNext']/div/button/div[2]")]

        public IWebElement next;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input")]

        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@id='passwordNext']/div/button/div[2]")]

        public IWebElement enter;

        public void GoogleLogin()
        {
            string mainWindow = driver.CurrentWindowHandle;          
            Thread.Sleep(3000);
            
            google.Click();
            List<string> window = driver.WindowHandles.ToList();
            foreach(var loginwindow in window)
            {
                driver.SwitchTo().Window(loginwindow);

            }
            Thread.Sleep(4000);
            
            gmail.SendKeys("rajkumar@gmail.com");
            Thread.Sleep(2000);            
            next.Click();
            Thread.Sleep(4000);           
            password.SendKeys("Rajesh");
            Thread.Sleep(3000);          
            enter.Click();
            Thread.Sleep(5000);
           
            driver.SwitchTo().Window(mainWindow);
            Thread.Sleep(3000);
        }

    }
}
