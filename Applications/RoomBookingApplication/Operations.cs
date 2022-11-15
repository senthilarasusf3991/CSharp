using System;

namespace RoomBookingApplication
{
    public partial class Operations
    {
        public static List<UserRegistration> userList=new List<UserRegistration>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static List<RoomDetails> roomList=new List<RoomDetails>();
        public static List<RoomSelectionDetails> roomSelectionList=new List<RoomSelectionDetails>();
        public static UserRegistration CurrentUser;

        public static void MainMenu()
        {
            
            System.Console.WriteLine("---------------------------------------------------------");
            System.Console.WriteLine("|                 WELCOME TO OUR SITE                    |");
            System.Console.WriteLine("---------------------------------------------------------");
            int option;
            do{
                System.Console.WriteLine("Enter the Option\n1.Customer Registration\n2.Customer Login\n3.Exit");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("  WELCOME TO REGISTRATION!! ");
                        UserRegistration();
                        break;
                        
                    }
                    case 2:
                    {
                        System.Console.WriteLine("  WELCOME TO LOGIN!! ");
                        UserLogin();
                        break;
                        
                    }
                    case 3:
                    {
                        System.Console.WriteLine("  THANK YOU FOR VISITING OUR SITE ");
                        
                        break;
                        
                    }
                    default:
                    {
                        System.Console.WriteLine("  OPTION INVALID, PLEASE ENTER THE CORRECT OPTION  ");
                        
                        break;
                        
                    }

                }
            }while(option!=3);

        
        }
        private static void UserRegistration()
        {
            FoodType foodType=FoodType.Default;
            Gender gender=Gender.Default;
            bool temp;
            long mobileNumber,aadharNumber;
            double walletBalance;
            string name,address;

            System.Console.WriteLine("Enter Your name: ");
            name=Console.ReadLine();
            System.Console.WriteLine("Enter Your mobile Number: ");
            temp=long.TryParse(Console.ReadLine(),out mobileNumber);
            while(!temp)
            {
                System.Console.WriteLine("Invalid...Enter in Numbers");
                temp=long.TryParse(Console.ReadLine(),out mobileNumber);

            }
            System.Console.WriteLine("Enter Your aadhar Number: ");
            temp=long.TryParse(Console.ReadLine(),out aadharNumber);
            while(!temp)
            {
                System.Console.WriteLine("Invalid...Enter in Numbers");
                temp=long.TryParse(Console.ReadLine(),out aadharNumber);

            }
            System.Console.WriteLine("Enter Your address: ");
            address=Console.ReadLine();
            System.Console.WriteLine("Enter Your Gender Male, Female, Transgender: ");
            while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out gender) || !(((int)gender>0) && ((int)gender<4)))
            {
                System.Console.WriteLine("Invalid choice,,Enter again");
            }
            System.Console.WriteLine("Enter Your FoodType: ");
            while(!Enum.TryParse<FoodType> (Console.ReadLine(),true,out foodType) || !(((int)foodType>0) && ((int)foodType<3)))
            {
                System.Console.WriteLine("Invalid choice Enter Again");
            }
            System.Console.WriteLine("Enter Your WalletBalance: ");
            temp=double.TryParse(Console.ReadLine(),out walletBalance);
            while(!temp)
            {
                System.Console.WriteLine("Invalid...Enter in Numbers");
                temp=double.TryParse(Console.ReadLine(),out walletBalance);
                

            }

            UserRegistration newUser=new UserRegistration(name,mobileNumber,aadharNumber,address,foodType,gender,walletBalance);
            userList.Add(newUser);

            System.Console.WriteLine($"Registration Successfull Your Registration ID is {newUser.UserID}");
        }
        private static void UserLogin()
        {
            bool flag=true;
            System.Console.WriteLine("Enter Your UserID: ");
            string userID=Console.ReadLine().ToUpper();

            foreach(UserRegistration user in userList)
            {
                if(user.UserID.Equals(userID))
                {
                    CurrentUser=user;
                    flag=false;
                    System.Console.WriteLine("UserID found");
                    SubMenu();

                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid User ID");
            }
        }
        private static void SubMenu()
        {
            int subOption;
            do
            {
                
                System.Console.WriteLine("Enter the Option You want to check");
                System.Console.WriteLine("1.ViewCustomerProfile\n2.BookRoom\n3.CancelBooking\n4.BookingHistory\n5.WalletRecharge\n6.Exit");
                subOption=int.Parse(Console.ReadLine());
                switch(subOption)
                {
                    case 1:
                    {
                        System.Console.WriteLine("    NOW WE ARE SHOWING THE CUSTOMER PROFILE    ");
                        ViewCustomerProfile();
                        break;
                    }
                    case 2:
                    {
                        
                        BookRoom();
                        break;
                    }
                    case 3:
                    {
                        
                        CancelBooking();
                        break;
                    }
                    case 4:
                    {
                        BookingHistory();
                        break;
                    }
                    case 5:
                    {
                        bool temp;
                        double amount;
                        System.Console.WriteLine("Enter the amount You want to recharge");
                        temp=double.TryParse(Console.ReadLine(),out amount);
                        CurrentUser.WalletRecharge(amount);
                        while (!temp)
                        {
                            System.Console.WriteLine("Enter in numbers");
                            temp=double.TryParse(Console.ReadLine(),out amount);

                        }
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Thank you !! You are entering the main menu again");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Choice Enter the correct choice");
                        break;
                    }

                }
            }while(subOption!=6);
            
        }
        private static void ViewCustomerProfile()
        {
            System.Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|       UserId    |       Name      |   Mobilenumber  | AadharNumber   |   Address       |      FoodType   |      Gender     | WalletBalance   |");
            System.Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------|");

            foreach(UserRegistration user in userList)
            {
                if(CurrentUser.UserID.Equals(user.UserID))
                {
                    user.ShowUserRegistration();
                    System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------------------|");
                }
            }
        }
        private static void BookRoom()
        {
            //Create temporary booking object whose UserID is currentUserID, TotalAmount 0, Bookingdate Now, Status as initiated
            //Create Temporary roomSelection List
            //Show the List of Available room
            //ask the user to enter DateFrom (Date and Time)  and DateTo (Date and Time), RoomID & no.Of Days of booking
            //need to check the room is already booked or not 
            //not booked means Create Room Selection object and add it to local room selection list
            bool temp, roomPresent = true, bookedFlag = true;
            bool roomCheck=true;
            DateTime dateFrom,dateTo;
            BookingDetails newBooking=new BookingDetails(CurrentUser.UserID,0,DateTime.Now,BookingStatus.Initiated);
            List<RoomSelectionDetails> tempRoomSelectionList=new List<RoomSelectionDetails>();
            string conditon="";
            do{
                System.Console.WriteLine("|---------------------------------------------------------------------|");
                System.Console.WriteLine("|     RoomID     |   RoomType    |  NumberOfBeds      | PricePerDay   |");
                System.Console.WriteLine("|---------------------------------------------------------------------|");
                foreach(RoomDetails room in roomList)
                {
                    room.ShowRoomDetails();
                    System.Console.WriteLine("|---------------------------------------------------------------------|");
                }
                System.Console.WriteLine("Enter the Room ID...");
                string roomID=Console.ReadLine().ToUpper();
                
                
                System.Console.WriteLine("Enter the DateFrom:dd/MM/yyyy hh:mm:ss tt format");
                temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out dateFrom);
                while(!temp)
                {
                    System.Console.WriteLine("Invalid format enter correct format");
                    temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out dateFrom);
                }
                System.Console.WriteLine("Enter the DateTo:dd/MM/yyyy hh:mm:ss tt ");
                temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out dateTo);
                while(!temp)
                {
                    System.Console.WriteLine("Invalid format enter correct format");
                    temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out dateTo);
                }
                
                
                TimeSpan newTimeSpan=dateTo.Subtract(dateFrom);
                double noOfDaysOfBooking=newTimeSpan.Days;

                
                DateTime tempDate = roomSelectionList[0].StayingDateTo;
                foreach (RoomSelectionDetails selection in roomSelectionList)
                {
                    if (selection.BookingStatus.Equals(BookingStatus.Booked) && selection.StayingDateTo > tempDate)
                    {
                        tempDate = selection.StayingDateTo;
                    }
                }
                foreach(RoomDetails room in roomList)
                {
                    if(room.RoomID.Equals(roomID))
                    {

                        roomCheck=false;
                        foreach(RoomSelectionDetails selection in roomSelectionList)
                        {
                            if(selection.RoomID.Equals(roomID))
                            {
                                roomPresent = false;
                                if (!selection.BookingStatus.Equals(BookingStatus.Booked) || dateFrom.Subtract(tempDate).TotalHours >= 0)
                                {
                                    bookedFlag = false;
                                    RoomSelectionDetails newSelection=new RoomSelectionDetails(roomID,newBooking.BookingID,dateFrom,dateTo,noOfDaysOfBooking*room.PricePerDay,noOfDaysOfBooking,BookingStatus.Booked);

                                    tempRoomSelectionList.Add(newSelection);
                                    System.Console.WriteLine($"Room selected successfully ,Your id is {newSelection.SelectionID}");
                                }
                            }
                        }
                        if (roomPresent)
                        {
                            RoomSelectionDetails newSelection=new RoomSelectionDetails(roomID,newBooking.BookingID,dateFrom,dateTo,noOfDaysOfBooking*room.PricePerDay,noOfDaysOfBooking,BookingStatus.Booked);
                            tempRoomSelectionList.Add(newSelection);
                            System.Console.WriteLine($"Room selected successfully ,Your id is {newSelection.SelectionID}");
                        }
                        if (!roomPresent && bookedFlag)
                        {
                            System.Console.WriteLine("Room unavailable..");
                        }
                    }
                }
                if(roomCheck)
                {
                    System.Console.WriteLine("Invalid room ID");
                }
                System.Console.WriteLine("Do You want to book another Room: Yes or No");
                conditon=Console.ReadLine().ToLower();
            }while(conditon=="yes");
            double totalRent=0;
            foreach(RoomSelectionDetails tempRoom in tempRoomSelectionList)
            {
                totalRent=tempRoom.Price+totalRent;
                tempRoom.BookingStatus=BookingStatus.Booked;
                if(CurrentUser.WalletBalance>=totalRent)
                {
                    roomSelectionList.AddRange(tempRoomSelectionList);
                    newBooking.TotalPrice = totalRent;
                    newBooking.BookingStatus = BookingStatus.Booked;
                    CurrentUser.WalletDeduct(totalRent);
                    bookingList.Add(newBooking);
                    System.Console.WriteLine($"Booked Successfylly, You booking ID iS {newBooking.BookingID}");
                    return;

                }
                else{
                    System.Console.WriteLine("Insufficient Balance recharge immedietly");

                    
                    double amount;
                    System.Console.WriteLine("Enter the amount You want to recharge");
                    temp=double.TryParse(Console.ReadLine(),out amount);
                    CurrentUser.WalletRecharge(amount);
                    while (!temp)
                    {
                        System.Console.WriteLine("Enter in numbers");
                        temp=double.TryParse(Console.ReadLine(),out amount);

                    }
                }
            }
        }
        private static void CancelBooking()
        {
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|   BookingID     |      UserID     |     TotalPrice  |   DateOfBooking |   BookingStatus |");
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            bool flag=true;
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.UserID.Equals(CurrentUser.UserID))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                    System.Console.WriteLine("|------------------------------------------------------------------------------------------|");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("No Booking history in Your account");
            }
            System.Console.WriteLine("Enter the booking ID that you want to cancel");
            string bookingID=Console.ReadLine().ToUpper();
            bool chekStatus=true;
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.UserID.Equals(CurrentUser.UserID))&&(booking.BookingStatus.Equals(BookingStatus.Booked))&&booking.BookingID.Equals(bookingID))
                {
                    chekStatus=false;
                    booking.BookingStatus=BookingStatus.Cancelled;
                    CurrentUser.WalletRecharge(booking.TotalPrice);
                    foreach(RoomSelectionDetails selection in roomSelectionList)
                    {
                        if(selection.BookingID.Equals(bookingID)&& CurrentUser.UserID.Equals(booking.UserID))
                        {
                            selection.BookingStatus=BookingStatus.Cancelled;
                            
                        }
                    }
                }
            }
            System.Console.WriteLine("Booking Cancelled Successfully");
            if(chekStatus)
            {
                System.Console.WriteLine("You booking status is already in  Cancelled status");
            }
        }
        private static void BookingHistory()
        {
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|   BookingID     |      UserID     |     TotalPrice  |   DateOfBooking |   BookingStatus |");
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            
            //show the current user’s booking history by traversing the booking details list 
            //need to ask the user to pick a booking ID 
            //based on that show the details of rooms booked by traversing room selection list. 
            bool flag=true;
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.UserID.Equals(CurrentUser.UserID))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                    System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");

                }
                
            }
            if(flag)
            {
                System.Console.WriteLine("No Booking history in Your account");
            }
            bool check=true;
            System.Console.WriteLine("select the Booking ID to show the Details");
            string bookingID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("| SelectionID   |  BookingID      |     RoomID      |  StayingDateFrom|   StayingDateTo |    Price       |     NumberOfDay |   BookingStatus |");
            System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------|");

            foreach(RoomSelectionDetails room in roomSelectionList)
            {
                if(room.BookingID.Equals(bookingID))
                {
                    check=false;
                    room.ShowRoomSelectionDetails();
                    System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------|");
                }
            }
            if(check)
            {
                System.Console.WriteLine("Booking ID invalid");
            }
            
            
        }
      

        public static void DefaultData()
        {
            UserRegistration user1=new UserRegistration("Ravichandran",995875777,347777378383,"Chennai",FoodType.Veg,Gender.Male,5000);
            UserRegistration user2=new UserRegistration("Baskaran ",448844848,474777477477,"Chennai",FoodType.NonVeg,Gender.Male,6000);

            userList.Add(user1);
            userList.Add(user2);

            RoomDetails room1=new RoomDetails(RoomType.Standard,2,500);
            RoomDetails room2=new RoomDetails(RoomType.Standard,4,700);
            RoomDetails room3=new RoomDetails(RoomType.Standard,2,500);
            RoomDetails room4=new RoomDetails(RoomType.Standard,2,500);
            RoomDetails room5=new RoomDetails(RoomType.Standard,2,500);
            RoomDetails room6=new RoomDetails(RoomType.Delux,2,1000);
            RoomDetails room7=new RoomDetails(RoomType.Delux,2,1000);
            RoomDetails room8=new RoomDetails(RoomType.Delux,4,1400);
            RoomDetails room9=new RoomDetails(RoomType.Delux,4,1400);
            RoomDetails room10=new RoomDetails(RoomType.Suit,2,2000);
            RoomDetails room11=new RoomDetails(RoomType.Suit,2,2000);
            RoomDetails room12=new RoomDetails(RoomType.Suit,2,2000);
            RoomDetails room13=new RoomDetails(RoomType.Suit,4,2500);
            roomList.Add(room1);
            roomList.Add(room2);
            roomList.Add(room3);
            roomList.Add(room4);
            roomList.Add(room5);
            roomList.Add(room6);
            roomList.Add(room7);
            roomList.Add(room8);
            roomList.Add(room9);
            roomList.Add(room10);
            roomList.Add(room11);
            roomList.Add(room12);
            roomList.Add(room13);

            RoomSelectionDetails selection1=new RoomSelectionDetails("RID101","BID101",new DateTime(2022,11,11,06,00,00,DateTimeKind.Utc),new DateTime (2022,11,12,02,00,00,DateTimeKind.Utc),750,1.5,BookingStatus.Booked);
            RoomSelectionDetails selection2=new RoomSelectionDetails("RID102","BID101",new DateTime(2022,11,11,10,00,00,DateTimeKind.Utc),new DateTime (2022,11,12,09,00,00,DateTimeKind.Utc),700,1,BookingStatus.Booked);
            RoomSelectionDetails selection3=new RoomSelectionDetails("RID103","BID102",new DateTime(2022,11,12,09,00,00,DateTimeKind.Utc),new DateTime (2022,11,13,09,00,00,DateTimeKind.Utc),500,1,BookingStatus.Cancelled);
            RoomSelectionDetails selection4=new RoomSelectionDetails("RID106","BID102",new DateTime(2022,11,12,06,00,00,DateTimeKind.Utc),new DateTime (2022,11,13,12,30,00,DateTimeKind.Utc),1500,1.5,BookingStatus.Cancelled);

            roomSelectionList.Add(selection1);
            roomSelectionList.Add(selection2);
            roomSelectionList.Add(selection3);
            roomSelectionList.Add(selection4);

            BookingDetails booking1=new BookingDetails("SF1001",1450,new DateTime(2022,11,10),BookingStatus.Booked);
            BookingDetails booking2=new BookingDetails("SF1002",2000,new DateTime(2022,11,10),BookingStatus.Cancelled);
            bookingList.Add(booking1);
            bookingList.Add(booking2);


            





        }
    }
}