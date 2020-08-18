using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MakeMyTrip.Page
{
    public class Hotel
    {
        public IWebDriver driver;

        public Hotel(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//nav//li[2]//a[1]")]

        public IWebElement Hotels;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/div[2]/div/div/div[1]/label/span")]

        public IWebElement City;

        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//div//div//div//div//div//div//input")]

        public IWebElement Search;

        [FindsBy(How = How.XPath, Using = "//li[1]//div[1]//div[1]//div[1]//p[1]")]

        public IWebElement MumbaiValue;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div[1]//div[3]//div[5]//div[3]")]
       
        public IWebElement Start;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div/div[2]/div/div/div[2]/div[1]/div/div/div/div[2]/div/div[2]/div[1]/div[3]/div[5]/div[7]")]
       
        public IWebElement End;

        [FindsBy(How = How.XPath, Using = "//button[@id='hsw_search_button']")]

        public IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='hlistpg_search_htl_name_box']//div//input")]

        public IWebElement SearchHotel;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Taj Mahal Palace, Mumbai, Maharashtra')]")]

        public IWebElement tajSelect;

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/div/div/div/div[2]/a[1]/div[1]/div[1]")]
       
        public IWebElement Taj;

        public void HotelSelect()
        {
            Hotels.Click();
            Thread.Sleep(10000);
            City.Click();
            Thread.Sleep(3000);
            Search.SendKeys("Mumbai");
            Thread.Sleep(3000);
            MumbaiValue.Click();
            Thread.Sleep(3000);
            Start.Click();
            End.Click();
            Thread.Sleep(3000);
            SearchButton.Click();
            Thread.Sleep(5000);
            SearchHotel.SendKeys("Taj Mahal palace");
            Thread.Sleep(2000);
            tajSelect.Click();
            Thread.Sleep(3000);
            Taj.Click();
            Thread.Sleep(3000);

        }

    }
}
