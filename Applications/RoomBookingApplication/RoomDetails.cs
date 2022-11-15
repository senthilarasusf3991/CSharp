using System;
namespace RoomBookingApplication
{
    public enum RoomType{Default, Standard, Delux, Suit}
    public class RoomDetails
    {
        public static int s_roomID=100;
        public string RoomID{get;}
        public RoomType RoomType{get;set;}
        public int NumberOfBeds{get;set;}
        public double PricePerDay{get;set;}
        public RoomDetails(RoomType roomType, int numberOfBeds,double pricePerDay)
        {
            s_roomID++;
            RoomID="RID"+s_roomID;
            RoomType=roomType;
            NumberOfBeds=numberOfBeds;
            PricePerDay=pricePerDay;
        }
        public RoomDetails (string data)
        {
            string[] values=data.Split(',');
            s_roomID=int.Parse(values[0].Remove(0,3));
            RoomID=values[0];
            RoomType=Enum.Parse<RoomType> (values[1],true);
            NumberOfBeds=int.Parse(values[2]);
            PricePerDay=double.Parse(values[3]);

        }
        public void ShowRoomDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15}|",RoomID,RoomType,NumberOfBeds,PricePerDay);
        }

    }
}