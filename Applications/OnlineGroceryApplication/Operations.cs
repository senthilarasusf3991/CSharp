using System;
namespace OnlineGroceryStore
{
    public partial class Operations
    {
        public static List<CustomerRegistration> customerList=new List<CustomerRegistration>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        private static CustomerRegistration currentCustomer;

        public static void MainMenu()
        {
            
            System.Console.WriteLine("---------------------------------------------------------");
            System.Console.WriteLine("                  WELCOME TO OUR SITE                  ");
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
                        CustomerRegistration();
                        break;
                        
                    }
                    case 2:
                    {
                        System.Console.WriteLine("  WELCOME TO LOGIN!! ");
                        CustomerLogin();
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

        
        private static void CustomerRegistration()
        {
            Gender gender=Gender.Default;
            System.Console.WriteLine("Enter your name:    ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father's Name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter Your Gender Male, Female, Transgender: ");
            while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out gender) || !(((int)gender>0) && ((int)gender<4)))
            {
                System.Console.WriteLine("Invalid choice");
            }
            System.Console.WriteLine("Enter your mobile number: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Date Of Birth: ");
            DateTime dOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter Your MailID");
            string mailID=Console.ReadLine();
            System.Console.WriteLine("Enter Your wallet Balance: ");
            double walletBalance=double.Parse(Console.ReadLine());

            CustomerRegistration customer=new CustomerRegistration(name,fatherName,gender,mobileNumber,dOB,mailID,walletBalance);
            customerList.Add(customer);

            System.Console.WriteLine($" Your Customer registration is successfully completed,Your ID is {customer.CustomerID} ");
            
        }
        private static void CustomerLogin()
        {
            System.Console.WriteLine("Enter your Login ID");
            string userID=Console.ReadLine().ToUpper();
            
            bool flag=true;
            foreach(CustomerRegistration customer in customerList)
            {
                if(userID.Equals(customer.CustomerID))
                {
                    currentCustomer=customer;
                    flag=false;
                    System.Console.WriteLine("UserID found");
                    SubMenu();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid ID enter again");
            }
            

        }
        private static void SubMenu()
        {
            int subOption;
            do
            {
                
                System.Console.WriteLine("Enter the Option You want to check");
                System.Console.WriteLine("1.Show Customer Details\n2.Show Product Details\n3.Wallet Recharge\n4.Take Order\n5.Modify Order Quantity\n6.Cancel Order\n7.Exit");
                subOption=int.Parse(Console.ReadLine());
                switch(subOption)
                {
                    case 1:
                    {
                        System.Console.WriteLine("    NOW WE ARE SHOWING THE CUSTOMER DETAILS    ");
                        ShowCustomerDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("  NOW YOU ARE SEEING THE PRODUCT DETAILS  ");
                        ShowProductDetails();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("   WALLET RECHARGE!!   ");
                        WalletRecharge();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("    TAKE YOUR ORDER    ");
                        TakeOrder();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("MODIFY ORDER QUANTITY");
                        ModifyOrderQuantity();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("CANCEL ORDER");
                        CancelOrder();
                        break;
                    }
                    case 7:
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
            }while(subOption!=7);
        }
        private static void ShowCustomerDetails()
        {
            System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("| CustomerID   | WalletBalance   |    Name       |  FatherName  | Gender   |  MobileNo    |     DOB      |    MailID      |");
            System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------|");
            foreach(CustomerRegistration customer in customerList)
            {
                if(customer.CustomerID.Equals(currentCustomer.CustomerID))
                {
                    System.Console.WriteLine("| {0,-12} | {1,-15} | {2,-12} | {3,-14} | {4,-8} | {5,-12} | {6,-12} | {7,-16} |",currentCustomer.CustomerID,currentCustomer.WalletBalance,currentCustomer.Name,currentCustomer.FatherName,currentCustomer.Gender,currentCustomer.MobileNumber,currentCustomer.DOB.ToString("dd/MM/yyyy"),currentCustomer.MailID);
                    System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------|");
                }
            }
        }
        private static void ShowProductDetails()
        {
            System.Console.WriteLine("|-------------------------------------------------------------------------|");
            System.Console.WriteLine("| ProductID   |    ProductName   | QuantityAvailable   | PricePerQuantity |");
            System.Console.WriteLine("|-------------------------------------------------------------------------|");
            foreach (ProductDetails product in productList)
            {
                System.Console.WriteLine("| {0,-11} | {1,-17} | {2,-19} | {3,-18} |",product.ProductID,product.ProductName,product.QuantityAvailable,product.PricePerQuantity);
                System.Console.WriteLine("|-------------------------------------------------------------------------|");
            }
        }
        private static void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount you want to Recharge to your wallet: ");
            double amount=double.Parse(Console.ReadLine());
            currentCustomer.WalletRecharge(amount);
            System.Console.WriteLine("    RECHARGED SUCCESSFULLY  ");
            System.Console.WriteLine($"Your wallet Balance after Recharge is Rupees: {currentCustomer.WalletBalance}");

        }
        private static void TakeOrder()
        {
            double totalPurchaseAmount=0;
            BookingDetails newBooking=new BookingDetails();
            List<OrderDetails> tempOrderList =new List<OrderDetails>();
            System.Console.WriteLine("Do you want to purchase Yes or NO..");
            string customerChoice=Console.ReadLine().ToLower();
            if(customerChoice=="yes")
            {
                newBooking=new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);

            }
            
            while(customerChoice=="yes")
            {
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                System.Console.WriteLine("| ProductID |     ProductName     |  QuantityAvailable |  PricePerQuantity  |");
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                foreach(ProductDetails product in productList)
                {
                    if(product.QuantityAvailable>0)
                    {
                        product.ShowProductDetails();
                        
                    }
                }
                System.Console.WriteLine("|---------------------------------------------------------------------------|");
                System.Console.WriteLine("Enter the Product ID to purchase the Product");
                string productID=Console.ReadLine().ToUpper();
                bool flag =true;
                foreach(ProductDetails product in productList)
                {
                    if(productID.Equals(product.ProductID))
                    {
                        flag=false;
                        System.Console.WriteLine("Enter the product quantity You want to Purchase");
                        int quantity=int.Parse(Console.ReadLine());
                        if(quantity<=product.QuantityAvailable)
                        {
                            OrderDetails newOrder=new OrderDetails(newBooking.BookingID,product.ProductID,quantity,quantity*product.PricePerQuantity);
                            tempOrderList.Add(newOrder);
                            product.QuantityAvailable-=quantity;
                            totalPurchaseAmount+=quantity*product.PricePerQuantity;
                            System.Console.WriteLine("Product Successfully added to Your cart");

                        }
                        else{
                            System.Console.WriteLine($"Stock Un available ,Avalilable stock is {product.QuantityAvailable}");
                        }
                    }
                }if(flag){
                    System.Console.WriteLine("Invalid Product ID");
                }
                System.Console.WriteLine("Do you want to Purchase Again: ");
                customerChoice=Console.ReadLine();
                

            
            }
            string choice;
            do
            {
                System.Console.WriteLine("Do You want to Confirm the Order: Yes or NO ");
                choice=Console.ReadLine().ToLower();
                if(choice=="yes")
                {
                    if(currentCustomer.WalletBalance>=totalPurchaseAmount)
                    {
                        currentCustomer.WalletBalance-=totalPurchaseAmount;
                        newBooking.BookingStatus=BookingStatus.Booked;
                        newBooking.TotalPrice=totalPurchaseAmount;
                        orderList.AddRange(tempOrderList);
                        System.Console.WriteLine("Your order is now Successfully Placed: ");
                        bookingList.Add(newBooking);
                        return;
                    }
                    else{
                        do{
                            System.Console.WriteLine("Your wallet Balance is Insufficient to take the order, please recharge");
                            WalletRecharge();

                        }while(currentCustomer.WalletBalance>=totalPurchaseAmount);
                    }

                }
            }while(choice=="yes");
            foreach(OrderDetails order in orderList)
            {
                foreach(ProductDetails product in productList)
                {
                    if(order.ProductID.Equals(product.ProductID))
                    {
                        product.QuantityAvailable+=order.PurchaseCount;
                    }
                }
            }    
        }
        private static void ModifyOrderQuantity()
        {
            bool check=true;
            BookingDetails userBooking=new BookingDetails();
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("| BookingID | CustomerID | TotalPrice | DateOfBooking | BookingStatus |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.CustomerID.Equals(currentCustomer.CustomerID))&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    check=false;
                    booking.ShowBookingDetails();
                }
            }
            if(check)
            {
                System.Console.WriteLine("Your booking histroy is empty, You haven't booked yet");
                check=true;
                return;
            }
            System.Console.WriteLine("|----------------------------------------------------------------|");
            System.Console.WriteLine("| OrderID | BookingID | ProductId | PurchaseCount | PriceOfOrder |");
            System.Console.WriteLine("|----------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.CustomerID.Equals(currentCustomer.CustomerID))&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    userBooking=booking;
                    foreach(OrderDetails order in orderList)
                    {
                        if(booking.BookingID.Equals(order.BookingID))
                        {
                            order.ShowOrderDetails();
                        }
                    }
                }
            }
            System.Console.WriteLine("|----------------------------------------------------------------|");
            System.Console.Write("Enter the order ID to modify the Order !! :");
            string orderID=Console.ReadLine().ToUpper();
            check=true;
            foreach(OrderDetails order in orderList)
            {
                if(orderID.Equals(order.OrderID))
                {
                    check=false;
                    foreach(ProductDetails product in productList)
                    {
                        if(order.ProductID.Equals(product.ProductID))
                        {
                            System.Console.Write("Enter the Quantity to modify :");
                            int quantity=int.Parse((Console.ReadLine()));
                            if((quantity-order.PurchaseCount)<=product.QuantityAvailable)
                            {
                                userBooking.TotalPrice-=order.PriceOfOrder;
                                product.QuantityAvailable=product.QuantityAvailable+(order.PurchaseCount-quantity);
                                order.PurchaseCount=quantity;
                                order.PriceOfOrder=quantity*product.PricePerQuantity;
                                userBooking.TotalPrice+=quantity*product.PricePerQuantity;
                                System.Console.WriteLine("Your order modified successfully!!");
                            }
                            else{
                                
                                System.Console.WriteLine("Stock Unavailableee....");
                                
                                return;
                            }
                        }
                    }
                }
            }
            if(check)
            {
                System.Console.WriteLine("INVALID ORDER ID");
            } 
        }
        private static void CancelOrder()
        {
            bool flag=true;
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("| BookingID | CustomerID | TotalPrice | DateOfBooking | BookingStatus |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.CustomerID.Equals(currentCustomer.CustomerID))&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    flag=false;
                    booking.ShowBookingDetails();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("your booking history is empty");
                return;
            }
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.Write("Enter the booking ID to cancel your booking:");
            string userBookingID=Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList)
            {
                if((booking.BookingID==userBookingID)&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    flag=false;
                    booking.BookingStatus=BookingStatus.Cancelled;
                    currentCustomer.WalletBalance+=booking.TotalPrice;
                    foreach(OrderDetails order in orderList)
                    {
                        if(booking.BookingID.Equals(order.BookingID))
                        {
                            foreach(ProductDetails product in productList)
                            {
                                if(order.ProductID.Equals(product.ProductID))
                                {
                                    product.QuantityAvailable+=order.PurchaseCount;
                                }
                            }
                        }
                    }
                    System.Console.WriteLine("BOOKING CANCELLED SUCCESSFULLY!!");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid BookingID...");
            }
        }
        public static void DefaultData()
        {
            CustomerRegistration customer1=new CustomerRegistration("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(1999,11,11),"ravi@gmail.com",10000);
            CustomerRegistration customer2= new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com",15000);
            customerList.Add(customer1);
            customerList.Add(customer2);

            ProductDetails product1=new ProductDetails("Sugar",20,40);
            ProductDetails product2=new ProductDetails("Rice",100,50);
            ProductDetails product3=new ProductDetails("Milk",10,40);
            ProductDetails product4=new ProductDetails("Coffee",10,10);
            ProductDetails product5=new ProductDetails("Tea",10,10);
            ProductDetails product6=new ProductDetails("Masala Powder",10,20);
            ProductDetails product7=new ProductDetails("Salt",10,10);
            ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
            ProductDetails product9=new ProductDetails("Chilli Powder",10,20);
            ProductDetails product10=new ProductDetails("Groundnut Oil",10,140);
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            productList.Add(product8);
            productList.Add(product9);
            productList.Add(product10);

            BookingDetails booking1 = new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking2=new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking3=new BookingDetails("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
            BookingDetails booking4=new BookingDetails("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
            bookingList.Add(booking4);

            OrderDetails order1=new OrderDetails("BID3001","PID101",2,80);
            OrderDetails order2=new OrderDetails("BID3001","PID102",2,100);
            OrderDetails order3=new OrderDetails("BID3001","PID103",1,40);
            OrderDetails order4=new OrderDetails("BID3002","PID101",1,40);
            OrderDetails order5=new OrderDetails("BID3002","PID102",4,200);
            OrderDetails order6=new OrderDetails("BID3002","PID110",1,140);
            OrderDetails order7=new OrderDetails("BID3002","PID109",1,20);
            OrderDetails order8=new OrderDetails("BID3003","PID102",2,100);
            OrderDetails order9=new OrderDetails("BID3003","PID108",4,100);
            OrderDetails order10=new OrderDetails("BID3003","PID101",2,80);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3); 
            orderList.Add(order4); 
            orderList.Add(order5); 
            orderList.Add(order6);
            orderList.Add(order7);
            orderList.Add(order8); 
            orderList.Add(order9); 
            orderList.Add(order10);
        }
    }
}