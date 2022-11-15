using System;
namespace MetroCardManagement
{
    public class TravelDetails
    {
        private static int s_travelID=100;
        public string TravelID{get;}
        public string CardNumber{get;set;}
        public string FromLocation{get;set;}
        public string ToLocation{get;set;}
        public DateTime Date{get;set;}
        public double TravelCost{get;set;}
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            s_travelID++;
            TravelID="TID"+s_travelID;
            CardNumber=cardNumber;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=travelCost;
        }
        public void ShowTravelHistory()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-15} | ",TravelID,CardNumber,FromLocation,ToLocation,Date.ToString("dd/MM/yyyy"),TravelCost);
        }
    }
}