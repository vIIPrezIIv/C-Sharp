using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace API_CSharp_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            String URI = "http://localhost:8080/COMP74A2/webresources/";
            RestClient client = new RestClient(URI);

            //--------------------------------------------------------------------------------------------

            RestRequest allClients = new RestRequest("clients");
            RestRequest singleClient = new RestRequest("clients/1");

            IRestResponse<List<Clients>> responseAllClients = client.Execute<List<Clients>>(allClients);
            IRestResponse<Clients> responseSingleClient = client.Execute<Clients>(singleClient);

            List<Clients> allClientsList = responseAllClients.Data;
            Clients singleClientOne = responseSingleClient.Data;

            Console.WriteLine("Client Class" + Environment.NewLine);
            Console.WriteLine(responseSingleClient.ResponseStatus + " " + responseSingleClient.StatusCode);
            Console.WriteLine("GET, single Client " + singleClientOne.id + " " + singleClientOne.name);

            Console.WriteLine(responseAllClients.ResponseStatus + " " + responseAllClients.StatusCode);
            for(int ctr = 0; ctr < allClientsList.Count; ctr++)
            {
                Console.WriteLine("GET, all Clients " + allClientsList[ctr].id + " " + allClientsList[ctr].name);
            }
            Console.WriteLine("-----------------------");

            //--------------------------------------------------------------------------------------------

            RestRequest allHotels = new RestRequest("hotels");
            RestRequest singleHotel = new RestRequest("hotels/2");

            IRestResponse<List<Hotels>> responseAllHotels = client.Execute<List<Hotels>>(allHotels);
            IRestResponse<Hotels> responseSingleHotel = client.Execute<Hotels>(singleHotel);

            List<Hotels> allHotelsList = responseAllHotels.Data;
            Hotels singleHotelOne = responseSingleHotel.Data;

            Console.WriteLine("Hotel Class" + Environment.NewLine);
            Console.WriteLine(responseSingleHotel.ResponseStatus + " " + responseSingleHotel.StatusCode);
            Console.WriteLine("GET, single Hotel " + singleHotelOne.id + " " + singleHotelOne.name + " " + singleHotelOne.hotelLocation);

            Console.WriteLine(responseAllHotels.ResponseStatus + " " + responseAllHotels.StatusCode);
            for (int ctr = 0; ctr < allHotelsList.Count; ctr++)
            {
                Console.WriteLine("GET, all Hotels " + allHotelsList[ctr].id + " " + allHotelsList[ctr].name + " " + allHotelsList[ctr].hotelLocation);
            }
            Console.WriteLine("-----------------------");

            //--------------------------------------------------------------------------------------------

            RestRequest allBookings = new RestRequest("bookings");
            RestRequest singleBooking = new RestRequest("bookings/3");
            RestRequest clientsHotels = new RestRequest("bookings/clients/1/hotels");
            RestRequest hotelsClients = new RestRequest("bookings/hotels/2/clients");
            RestRequest clientsByDate = new RestRequest("bookings/clients/hotels/01/01/2000");

            IRestResponse<List<Bookings>> responseAllBookings = client.Execute<List<Bookings>>(allBookings);
            IRestResponse<Bookings> responseSingleBooking = client.Execute<Bookings>(singleBooking);
            IRestResponse<List<Hotels>> responseClientsHotels = client.Execute<List<Hotels>>(clientsHotels);
            IRestResponse<List<Clients>> responseHotelsClients = client.Execute<List<Clients>>(hotelsClients);
            IRestResponse<List<Clients>> responseClientsByDate = client.Execute<List<Clients>>(clientsByDate);
          
            List<Bookings> allBookingsList = responseAllBookings.Data;
            Bookings singleBookingOne = responseSingleBooking.Data;
            List<Hotels> hotelsClientsList = responseClientsHotels.Data;
            List<Clients> clientsHotelsList = responseHotelsClients.Data;
            List<Clients> clientsByDateList = responseClientsByDate.Data;

            Console.WriteLine("Booking Class" + Environment.NewLine);
            Console.WriteLine(responseSingleBooking.ResponseStatus + " " + responseSingleBooking.StatusCode);
            Console.WriteLine("GET, single Booking " + singleBookingOne.id + " " + singleBookingOne.bookingId + " " + singleBookingOne.bookingMonth + " " +
                                                       singleBookingOne.bookingDay + " " + singleBookingOne.bookingYear + " " + singleBookingOne.arrivalDate + " " +
                                                       singleBookingOne.vacancyDate + " " + singleBookingOne.destination + " " + singleBookingOne.departure + " " +
                                                       singleBookingOne.hotelId + " " + singleBookingOne.clientId);

            Console.WriteLine(responseAllBookings.ResponseStatus + " " + responseAllBookings.StatusCode);
            for (int ctr = 0; ctr < allBookingsList.Count; ctr++)
            {
                Console.WriteLine("GET, all Bookings " + allBookingsList[ctr].id + " " + allBookingsList[ctr].bookingId + " " + allBookingsList[ctr].bookingMonth + " " +
                                                         allBookingsList[ctr].bookingDay + " " + allBookingsList[ctr].bookingYear + " " + allBookingsList[ctr].arrivalDate + " " +
                                                         allBookingsList[ctr].vacancyDate + " " + allBookingsList[ctr].destination + " " + allBookingsList[ctr].departure + " " +
                                                         allBookingsList[ctr].hotelId + " " + allBookingsList[ctr].clientId);
            }


            Console.WriteLine(responseClientsHotels.ResponseStatus + " " + responseClientsHotels.StatusCode);
            for (int ctr = 0; ctr < clientsHotelsList.Count; ctr++)
            {
                Console.WriteLine("GET, all Clients who stayed at Hotels " + clientsHotelsList[ctr].id + " " + clientsHotelsList[ctr].name);
            }

            Console.WriteLine(responseHotelsClients.ResponseStatus + " " + responseHotelsClients.StatusCode);
            for (int ctr = 0; ctr < hotelsClientsList.Count; ctr++)
            {
                Console.WriteLine("GET, all Hotels who had Clients " + hotelsClientsList[ctr].id + " " + hotelsClientsList[ctr].name + " " + hotelsClientsList[ctr].hotelLocation);
            }

            Console.WriteLine(responseClientsByDate.ResponseStatus + " " + responseClientsByDate.StatusCode);
            for (int ctr = 0; ctr < clientsByDateList.Count; ctr++)
            {
                Console.WriteLine("GET, all Clients By Date " + clientsByDateList[ctr].id + " " + clientsByDateList[ctr].name);
            }

            Console.WriteLine("-----------------------");

            Console.ReadLine();
        }
    }
}
