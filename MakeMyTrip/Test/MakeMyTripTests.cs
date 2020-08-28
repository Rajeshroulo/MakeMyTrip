using MakeMyTrip.Data;
using MakeMyTrip.Page;
using NUnit.Framework;
using MakeMyTrip.Base;

namespace MakeMyTrip.Test
{
    public class MakeMyTripTests : BaseClass
    {
        UserData data = new UserData();

        [Test,Order(1)]
        public void AccountLogin()
        {            
             var login = new LoginPage(driver);
             login.GoogleLogin(data.email, data.password);
             string title = "MakeMyTrip - #1 Travel Website 50% OFF on Hotels, Flights & Holiday";
             Assert.AreEqual(title, driver.Title);            
        }

        [Test,Order(2)]
        public void FlightSearch()
        {
             var flight = new FlightsPage(driver);
             flight.FlightBooking();
             string title = "Makemytrip";
             Assert.AreEqual(title, driver.Title);            
        } 
             
        [Test,Order(3)]
        public void SelectHotel()
        {           
             var hotel = new HotelPage(driver);
             hotel.HotelSelect();
             hotel.SearchHotel();
             string name = "The Taj Mahal Palace";
             Assert.AreEqual(name, hotel.TajHotel());            
        }  
        
        [Test,Order(4)]
        public void SearchTrains()
        {           
             var trains = new TrainsPage(driver);
             trains.FindTrains();
             string mailId = "rajraval017@gmail.com";
             Assert.AreEqual(mailId, trains.MailId());
        } 
    }
}
