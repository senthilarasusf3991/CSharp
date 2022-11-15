using System;
namespace RoomBookingApplication
{
    public class BookingDetails
    {
        /// <summary>
        /// Belongs to class <see Cref="Booking Details"/>that stored the Identity of each object
        /// </summary>
        private static int s_bookingID=100;
        /// <summary>
        /// It is an unique Identity auto generated for each booking
        /// </summary>
        /// <value></value>
        public string BookingID{get;}
        /// <summary>
        /// It shows the Identity of User class
        /// </summary>
        /// <value></value>
        public string UserID{get;set;}
        public double TotalPrice{get;set;}
        public DateTime DateOfBooking{get;set;}
        public BookingStatus BookingStatus {get;set;}
        /// <summary>
        /// Benongs to class <see Cref="Booking details"/> that initiates the Property and method of class
        /// </summary>
        /// <param name="userID">It passes the user Identity</param>
        /// <param name="totalPrice">ITt passes the Total Price</param>
        /// <param name="dateOfBooking"></param>
        /// <param name="bookingStatus"></param>

        public BookingDetails(string userID,double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            UserID=userID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
            
        }
        public BookingDetails(string data)
        {
            string[] values=data.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            UserID=values[1];
            TotalPrice=double.Parse(values[2]);
            DateOfBooking=DateTime.Parse(values[3]);
            BookingStatus=Enum.Parse<BookingStatus>(values[4]);
        }
     
        public void ShowBookingDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |",BookingID,UserID,TotalPrice,DateOfBooking.ToString("dd/MM/yyyy"),BookingStatus);
        }

    }
}