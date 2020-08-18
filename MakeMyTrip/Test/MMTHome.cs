using MakeMyTrip.Base;
using MakeMyTrip.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MakeMyTrip.Test
{
    public class MMTHome : MMTBase
    {

        [Test,Order(1)]
        public void Loginmmt()
        {
            try
            {
                var login = new Login(driver);
                login.GoogleLogin();

                string title = "MakeMyTrip - #1 Travel Website 50% OFF on Hotels, Flights & Holiday";
                Assert.AreEqual(title, driver.Title);

            }

            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            
        }
             
        [Test,Order(2)]
        public void HotelSelection()
        {
            try
            {
                var hotel = new Hotel(driver);
                hotel.HotelSelect();

                string name = "The Taj Mahal Palace";
                Assert.AreEqual(name, hotel.TajHotel());

            }

            catch(Exception e)
            {
                ITakesScreenshot sc = driver as ITakesScreenshot;
                Screenshot st = sc.GetScreenshot();
                st.SaveAsFile(@"C:\Users\HP\source\repos\MakeMyTrip\MakeMyTrip\Page\Hotel.cs\\hotel.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }

        }

    }
}
