using System;

namespace CafeteriaCardManagement
{
    public partial class Operations
    {
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static List<FoodDetails> foodList=new List<FoodDetails>();
        public static List<CartItem> cartItemList=new List<CartItem>();
        public static UserDetails CurrentUser;
        public static void MainMenu()
        {
            
            System.Console.WriteLine("---------------------------------------------------------");
            System.Console.WriteLine("|                 WELCOME TO OUR SITE                    |");
            System.Console.WriteLine("---------------------------------------------------------");
            int option;
            do{
                System.Console.WriteLine("Enter the Option\n1.UserRegistration\n2.UserLogin\n3.Exit");
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
            
            Gender gender=Gender.Default;
            bool temp;
            long mobileNumber;
            double walletBalance;
            string name,fatherName,mailID,workStationNumber;

            System.Console.WriteLine("Enter Your Name: ");
            name=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your FatherName: ");
            fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter Your mobile Number: ");
            temp=long.TryParse(Console.ReadLine(),out mobileNumber);
            while(!temp)
            {
                System.Console.WriteLine("Invalid...Enter in Numbers");
                temp=long.TryParse(Console.ReadLine(),out mobileNumber);

            }
        
            System.Console.WriteLine("Enter Your MailID: ");
            mailID=Console.ReadLine();

            System.Console.WriteLine("Enter Your Gender Male, Female, Transgender: ");
            while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out gender) || !(((int)gender>0) && ((int)gender<4)))
            {
                System.Console.WriteLine("Invalid choice,,Enter again");
            }
            System.Console.WriteLine("Enter Your WorkStation Number: ");
            workStationNumber=Console.ReadLine().ToUpper();


            
            System.Console.WriteLine("Enter Your WalletBalance: ");
            temp=double.TryParse(Console.ReadLine(),out walletBalance);
            while(!temp)
            {
                System.Console.WriteLine("Invalid...Enter in Numbers");
                temp=double.TryParse(Console.ReadLine(),out walletBalance);
                

            }

            UserDetails newUser=new UserDetails(name,fatherName,gender,mobileNumber,mailID,workStationNumber,walletBalance);
            userList.Add(newUser);

            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine($"Registration Successfull Your Registration ID is {newUser.UserID}");
            Console.ResetColor();
        }
        private static void UserLogin()
        {
            bool flag=true;
            System.Console.WriteLine("Enter Your UserID: ");
            string userID=Console.ReadLine().ToUpper();

            foreach(UserDetails user in userList)
            {
                if(user.UserID.Equals(userID))
                {
                    CurrentUser=user;
                    flag=false;
                    Console.ForegroundColor=ConsoleColor.Green;
                    System.Console.WriteLine("UserID found");
                    Console.ResetColor();
                    SubMenu();

                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine("Invalid User ID");
                Console.ResetColor();
            }
        }
        private static void SubMenu()
        {
            int subOption;
            do
            {
                
                System.Console.WriteLine("Enter the Option,that You want to check");
                System.Console.WriteLine("1.ShowMyProfile\n2.FoodOrder\n3.CancelOrder\n4.OrderHistory\n5.WalletRecharge\n6.Exit");
                subOption=int.Parse(Console.ReadLine());
                switch(subOption)
                {
                    case 1:
                    {
                        System.Console.WriteLine("    NOW WE ARE SHOWING THE CUSTOMER PROFILE    ");
                        ShowMyProfile();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine(" TAKE YOUR ORDER!!");
                        FoodOrder();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("CANCEL YOUR ORDER HERE!!");
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("YOUR ORDER HISTORY");
                        OrderHistory();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("RECHARGE!!");
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
                        System.Console.WriteLine("Thank you !! You are entering the MainMenu again");
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
        private static void ShowMyProfile()
        {
            System.Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|       UserId    |       Name      |   FatherName    | MobileNumber   |    MailID       |      Gender     |WorkstationNumber| WalletBalance   |");
            System.Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------|");
            //If user Id is present in the user list the show the Profile of current user.
            foreach(UserDetails user in userList)
            {
                if(CurrentUser.UserID.Equals(user.UserID))
                {
                    user.ShowUserDetails();
                    System.Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------------------|");
                }
            }
        }
        private static void FoodOrder()
        {
            double totalAmount=0;
            //creating a object for order
            OrderDetails newOrder=new OrderDetails(CurrentUser.UserID,DateTime.Now,0,OrderStatus.Initiated);
            //creating local cart list
            List<CartItem> localCartList =new List<CartItem>();
            //asking the user whether he really wants to purachse ,if yes means we are proceding
            System.Console.WriteLine("Do you want to purchase Yes or NO..");
            string customerChoice=Console.ReadLine().ToLower();
            while(customerChoice=="yes")
            {
                //showing the food details
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                System.Console.WriteLine("|   FoodID  |     FoodName        |  PricePerQuantity |  QuantityAvailable  |");
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                foreach(FoodDetails food in foodList)
                {
                    //checking weather the food quantity is available
                    if(food.AvailableQuantity>0)
                    {
                        food.ShowFoodDetails();
                        
                    }
                }
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                System.Console.WriteLine("Enter the food ID to purchase");
                string foodID=Console.ReadLine().ToUpper();
                bool flag =true;
                foreach(FoodDetails food in foodList)
                {
                    //Checking the food id is present 
                    if(foodID.Equals(food.FoodID))
                    {
                        flag=false;
                        //Getting the Quantity that user wants to purchase
                        System.Console.WriteLine("Enter the Food quantity that You want to Purchase");
                        int quantity=int.Parse(Console.ReadLine());
                        //Comparing with the available quantity
                        if(quantity<=food.AvailableQuantity)
                        {
                            CartItem newCart=new CartItem(newOrder.OrderID,food.FoodID,quantity*food.FoodPrice,quantity);
                            localCartList.Add(newCart);
                            food.AvailableQuantity-=quantity;
                            totalAmount=totalAmount+quantity*food.FoodPrice;
                            Console.ForegroundColor=ConsoleColor.Green;
                            System.Console.WriteLine("Product Successfully added to Your cart");
                            Console.ResetColor();

                        }
                        else{
                            System.Console.WriteLine($"Stock Un available ,Avalilable stock is {food.AvailableQuantity}");
                        }
                    }
                }if(flag){
                    //If product id is invalid we have to show the product id is invalid
                    System.Console.WriteLine("Invalid Product ID");
                }
                System.Console.WriteLine("Do you want to Purchase Again: ");
                customerChoice=Console.ReadLine();
                

            
            }
            string userChoice;
            do
            {
                //Asking the user whether he really wants to confirm the order
                System.Console.WriteLine("Do You want to Confirm the Order: Yes or NO ");
                userChoice=Console.ReadLine().ToLower();
                if(userChoice=="yes")
                {
                    if(CurrentUser.WalletBalance>=totalAmount)
                    {
                        CurrentUser.WalletDeduct(totalAmount);
                        cartItemList.AddRange(localCartList);
                        newOrder.OrderStatus=OrderStatus.Ordered;
                        newOrder.TotalPrice=totalAmount;

                        orderList.Add(newOrder);
                        //Placing the order and showing the order ID
                        System.Console.WriteLine($"Your Order Placed Successfully, your order ID is {newOrder.OrderID}");
                        return;
                    }
                    else{
                        do{
                            //IF balance is low asking to recharge the account
                            System.Console.WriteLine("Your wallet Balance is Insufficient to take the order, please recharge");
                            System.Console.WriteLine("RECHARGE!!");
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

                        }while(CurrentUser.WalletBalance>=totalAmount);
                    }
                }

            }while(userChoice=="yes");
            foreach(CartItem cart in cartItemList)
            {
                foreach(FoodDetails food in foodList)
                {
                    if(cart.FoodID.Equals(food.FoodID))
                    {
                        food.AvailableQuantity+=cart.OrderQuantity;
                    }
                }
            } 
   
        }
        
        private static void CancelOrder()
        {
            //Need to check whether UserID in order list is Same as the Current User ID
            //If Yes means We can show the history of custom
    
       

            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|    OrderID      |      UserID     |     OrderDate   |    TotalPrice   |   OrderStatus   |");
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            bool flag=true;
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID.Equals(CurrentUser.UserID))
                {
                    flag=false;
                    order.ShowOrderDetails();
                    System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine("No Booking history in Your account");
                Console.ResetColor();
            }
            //Ask the user to pick an OrderID to cancel.
            System.Console.WriteLine("Enter the Order ID that you want to cancel");
            string OrderID=Console.ReadLine().ToUpper();
            bool chekStatus=true;
            //Check the OrderID is valid.
            foreach(OrderDetails order in orderList)
            {
                if(OrderID.Equals(order.OrderID))
                {
                    chekStatus=false;
                    //If valid, then Return the Order total amount to current user. 
                    CurrentUser.WalletRecharge(order.TotalPrice);
                    //Return product orderQuantity to Foodtem list food quantity. 
                    foreach(CartItem cart in cartItemList)
                    {
                        if(cart.OrderID.Equals(order.OrderID))
                        {
                            foreach(FoodDetails food in foodList)
                            {
                                if(food.FoodID.Equals(cart.FoodID))
                                {
                                    food.AvailableQuantity+=cart.OrderQuantity;
                                    // Change the OrderStatus as Cancelled.
                                    order.OrderStatus=OrderStatus.Cancelled;

                                    
                                }
                            }

                        }

                    }
                    Console.ForegroundColor=ConsoleColor.Green;
                    System.Console.WriteLine("Your order Cancelled Successfully");
                    Console.ResetColor();
                    

                    


                }
            }
            if(chekStatus)
            {
                // If not, then show “Invalid OrderID”.
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine("Invalid Order ID");
                Console.ResetColor();
            }


        }
        private static void OrderHistory()
        {
            //Need to check whether UserID in order list is Same as the Current User ID
            //If Yes means We can show the history of customer
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|    OrderID      |      UserID     |     OrderDate   |    TotalPrice   |   OrderStatus   |");
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
            bool flag=true;
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID.Equals(CurrentUser.UserID))
                {
                    flag=false;
                    order.ShowOrderDetails();
                    System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
                }
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine("No Booking history in Your account");
                Console.ResetColor();
            }
        }


  
        public static void DefaultData()
        {
            UserDetails user1=new UserDetails("Ravichandran","Ettapparajan",Gender.Male,8857777575,"ravi@gmail.com","WS101",400);
            UserDetails user2=new UserDetails("Baskaran","Sethurajan",Gender.Male,9577747744,"baskaran@gmail.com","WS105",500);

            userList.Add(user1);
            userList.Add(user2);
            
            FoodDetails food1=new FoodDetails("Coffee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,10);

            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);

            OrderDetails order1=new OrderDetails("SF1001",new DateTime(2022,06,15),70,OrderStatus.Ordered);
            OrderDetails order2=new OrderDetails("SF1002",new DateTime(2022,06,15),100,OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);

            CartItem cartItem1=new CartItem("OID1001","FID101",20,1);
            CartItem cartItem2=new CartItem("OID1001","FID103",10,1);
            CartItem cartItem3=new CartItem("OID1001","FID105",40,1);
            CartItem cartItem4=new CartItem("OID1002","FID103",10,1);
            CartItem cartItem5=new CartItem("OID1002","FID104",50,1);
            CartItem cartItem6=new CartItem("OID1002","FID105",40,1);

            cartItemList.Add(cartItem1);
            cartItemList.Add(cartItem2);
            cartItemList.Add(cartItem3);
            cartItemList.Add(cartItem4);
            cartItemList.Add(cartItem5);
            cartItemList.Add(cartItem6);


        }
    }
}