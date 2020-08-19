using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;


namespace MakeMyTrip.Base
{
    public class MakeMyTrip
    {
        public IWebDriver driver; 
        [OneTimeSetUp]
        public void StartBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications", "start-maximized");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.makemytrip.com";
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}
