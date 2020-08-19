using MakeMyTrip.Base;
using MakeMyTrip.Data;
using MakeMyTrip.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using System.IO;


namespace MakeMyTrip.Test
{
    public class MMTHome : MMTBase
    {
        UserData data = new UserData();

        [Test,Order(1)]
        public void Loginmmt()
        {
            try
            {
                var login = new Login(driver);
                login.GoogleLogin(data.email, data.password);

                string title = "MakeMyTrip - #1 Travel Website 50% OFF on Hotels, Flights & Holiday";
                Assert.AreEqual(title, driver.Title);

            }

            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                
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
               Console.WriteLine(e.StackTrace);
            }

        }

    }
}
