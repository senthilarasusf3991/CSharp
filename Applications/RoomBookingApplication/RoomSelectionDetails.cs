using System;
namespace RoomBookingApplication
{
    public enum BookingStatus{Default,Initiated, Booked, Cancelled}
    public class RoomSelectionDetails

    {
        private static int s_selectionID=1000;
        public string SelectionID{get;}

        public string RoomID{get;set;}
        public string BookingID{get;set;}
        public DateTime StayingDateFrom{get;set;}
        public DateTime StayingDateTo{get;set;}
        public double Price{get;set;}
        public double NumberOfDays{get;set;}
        public BookingStatus BookingStatus {get;set;}
        public RoomSelectionDetails(string roomID,string bookingID,DateTime stayingDateFrom,DateTime stayingDateTo,double price,double numberOfDays,BookingStatus bookingStatus)
        {
            s_selectionID++;
            SelectionID="SID"+s_selectionID;
            RoomID=roomID;
            BookingID=bookingID;
            StayingDateFrom=stayingDateFrom;
            StayingDateTo=stayingDateTo;
            Price=price;
            NumberOfDays=numberOfDays;
            BookingStatus=bookingStatus;

        }
        public RoomSelectionDetails(string data)
        {
            string[] values=data.Split(',');
            s_selectionID=int.Parse(values[0].Remove(0,3));
            SelectionID=values[0];
            RoomID=values[1];
            BookingID=values[2];
            StayingDateFrom=DateTime.Parse(values[3]);
            StayingDateTo=DateTime.Parse(values[4]);
            Price=double.Parse(values[5]);
            NumberOfDays=double.Parse(values[6]);
            BookingStatus=Enum.Parse<BookingStatus>(values[7]);

        }
        public void ShowRoomSelectionDetails()
        {
            System.Console.WriteLine("|{0,-15}| {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-15} | {6,-15} | {7,-15} |",SelectionID,BookingID,RoomID,StayingDateFrom.ToLongTimeString(),StayingDateTo.ToLongTimeString(),Price,NumberOfDays,BookingStatus);
        }

    }
}