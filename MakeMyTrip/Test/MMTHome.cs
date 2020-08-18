using MakeMyTrip.Base;
using MakeMyTrip.Page;
using NUnit.Framework;

namespace MakeMyTrip.Test
{
    public class MMTHome : MMTBase
    {

        [Test,Order(1)]
        public void Loginmmt()
        {
            var login = new Login(driver);
            login.GoogleLogin();

            string title = "MakeMyTrip - #1 Travel Website 50% OFF on Hotels, Flights & Holiday";
            Assert.AreEqual(title, driver.Title);
        }
             
      [Test,Order(2)]
      public void HotelSelection()
      {
            var hotel = new Hotel(driver);
             hotel.HotelSelect();
            string name = "The Taj Mahal Palace";
            Assert.AreEqual(name, hotel.TajHotel());

      }

    }
}
