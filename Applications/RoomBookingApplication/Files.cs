using System.IO;
using System;
namespace RoomBookingApplication
{
    public class Files
    {
        public static void  Create()
        {
            if(!Directory.Exists("RoomBooking"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("RoomBooking");
            }
            else{
                System.Console.WriteLine("Folder exist");
            }
            if(!File.Exists("RoomBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("RoomBooking/BookingDetails.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }
            if(!File.Exists("RoomBooking/RoomDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("RoomBooking/RoomDetails.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }
            if(!File.Exists("RoomBooking/RoomSelectionDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("RoomBooking/RoomSelectionDetails.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }
            if(!File.Exists("RoomBooking/Userregistration.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("RoomBooking/Userregistration.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }


        }
        public static void Write()
        {
            string[] bookingDetails=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                //BookingID,UserID,TotalPrice,DateOfBooking.ToString("dd/MM/yyyy"),BookingStatus
                bookingDetails[i]=Operations.bookingList[i].BookingID+','+Operations.bookingList[i].UserID+','+Operations.bookingList[i].TotalPrice+','+Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+','+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("RoomBooking/BookingDetails.csv",bookingDetails);

            string[] roomDetails=new string[Operations.roomList.Count];
            for(int i=0;i<Operations.roomList.Count;i++)
            {
                //RoomID,RoomType,NumberOfBeds,PricePerDay
                roomDetails[i]=Operations.roomList[i].RoomID+','+Operations.roomList[i].RoomType+','+Operations.roomList[i].NumberOfBeds+','+Operations.roomList[i].PricePerDay;
            }
            File.WriteAllLines("RoomBooking/RoomDetails.csv",roomDetails);

            string[] roomSelectionDetails=new string[Operations.roomSelectionList.Count];
            for(int i=0;i<Operations.roomSelectionList.Count;i++)
            {
                //SelectionID,BookingID,RoomID,StayingDateFrom.ToLongTimeString(),StayingDateTo.ToLongTimeString(),Price,NumberOfDays,BookingStatus
                roomSelectionDetails[i]=Operations.roomSelectionList[i].SelectionID+','+Operations.roomSelectionList[i].BookingID+','+Operations.roomSelectionList[i].RoomID+','+Operations.roomSelectionList[i].StayingDateFrom.ToString("dd/MM/yyyy hh:mm:ss tt")+','+Operations.roomSelectionList[i].StayingDateTo.ToString("dd/MM/yyyy hh:mm:ss tt")+','+Operations.roomSelectionList[i].Price+','+Operations.roomSelectionList[i].NumberOfDays+','+Operations.roomSelectionList[i].BookingStatus;
            }
            File.WriteAllLines("RoomBooking/RoomSelectionDetails.csv",roomSelectionDetails);

            string[] userRegistration=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                //UserID,Name,MobileNumber,AadharNumeber,Address,FoodType,Gender,WalletBalance
                userRegistration[i]=Operations.userList[i].UserID+','+Operations.userList[i].Name+','+Operations.userList[i].MobileNumber+','+Operations.userList[i].AadharNumeber+','+Operations.userList[i].Address+','+Operations.userList[i].FoodType+','+Operations.userList[i].Gender+','+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("RoomBooking/UserRegistration.csv",userRegistration);


        }
        public static void Read()
        {
            string[] bookingInfo=File.ReadAllLines("RoomBooking/BookingDetails.csv");
            foreach(string data in bookingInfo)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookingList.Add(booking);
                
            }

            string[] roomInfo=File.ReadAllLines("RoomBooking/RoomDetails.csv");
            foreach(string data in roomInfo)
            {
                RoomDetails room=new RoomDetails(data);
                Operations.roomList.Add(room);
                
            }

            string[] roomSelectionInfo=File.ReadAllLines("RoomBooking/RoomSelectionDetails.csv");
            foreach(string data in roomSelectionInfo)
            {
                RoomSelectionDetails selection=new RoomSelectionDetails(data);
                Operations.roomSelectionList.Add(selection);
                
            }

            string[] userInfo=File.ReadAllLines("RoomBooking/UserRegistration.csv");
            foreach(string data in userInfo)
            {
                string[] values=data.Split(',');
                UserRegistration newUser=new UserRegistration(values[1],long.Parse(values[2]),long.Parse(values[3]),values[4],Enum.Parse<FoodType>(values[5],true),Enum.Parse<Gender>(values[6],true),double.Parse(values[7]));
                Operations.userList.Add(newUser);
            }


            
        }

        
        
    }
}