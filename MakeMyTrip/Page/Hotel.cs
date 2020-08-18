using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
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

        public IWebElement hotels;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/div[2]/div/div/div[1]/label/span")]

        public IWebElement city;

        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//div//div//div//div//div//div//input")]

        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//li[1]//div[1]//div[1]//div[1]//p[1]")]

        public IWebElement mumbaiValue;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div[1]//div[3]//div[5]//div[3]")]
       
        public IWebElement start;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div/div[2]/div/div/div[2]/div[1]/div/div/div/div[2]/div/div[2]/div[1]/div[3]/div[5]/div[7]")]
       
        public IWebElement end;

        [FindsBy(How = How.XPath, Using = "//button[@id='hsw_search_button']")]

        public IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='hlistpg_search_htl_name_box']//div//input")]

        public IWebElement searchHotel;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Taj Mahal Palace, Mumbai, Maharashtra')]")]

        public IWebElement tajSelect;

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/div/div/div/div[2]/a[1]/div[1]/div[1]")]
       
        public IWebElement taj;
        
        [FindsBy(How = How.XPath, Using = "//h1[@id='detpg_hotel_name']")]

        public IWebElement tajName;


        public void HotelSelect()
        {
            hotels.Click();
            Thread.Sleep(8000);
            city.Click();
            Thread.Sleep(3000);
            search.SendKeys("Mumbai");
            Thread.Sleep(5000);
            mumbaiValue.Click();
            Thread.Sleep(3000);
            start.Click();
            end.Click();
            Thread.Sleep(3000);
            searchButton.Click();
            Thread.Sleep(3000);
            searchHotel.SendKeys("Taj Mahal palace");
            Thread.Sleep(5000);
            tajSelect.Click();
            Thread.Sleep(3000);
            taj.Click();
            Thread.Sleep(5000);

            List<string> windows = driver.WindowHandles.ToList();

            foreach(var hotelwindow in windows)
            {
                driver.SwitchTo().Window(hotelwindow);
            }

        }

        public string TajHotel()
        {
            return tajName.Text;
        }

    }
}
