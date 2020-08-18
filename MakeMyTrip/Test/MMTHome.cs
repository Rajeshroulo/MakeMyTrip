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
        }
             
      [Test,Order(2)]
      public void HotelSelection()
      {

            var hotel = new Hotel(driver);
            hotel.HotelSelect();

      }

    }
}
