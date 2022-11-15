using System;
using System.Collections.Generic;

namespace MedicalStore
{
    public class Operations
    {
        private static List<Userdetails> userList=new List<Userdetails>(); 
        private static List<OrderDetails> orderList=new List<OrderDetails>(); 
        private static List<MedicineDetails> medicineList=new List<MedicineDetails>();
        private static Userdetails currentLoggedUser;
       
        public static void DefaultDetails() //DEFAULT DATAS OF USER,MEDICINE AND ORDER
        {
            Userdetails user1=new Userdetails ("Ravi",33,"Theni",9877774440,400);
            Userdetails user2=new Userdetails ("Baskaran",33,"Chennai",8847757470,500);
            MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,Convert.ToDateTime("30/06/2023"));
            MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,Convert.ToDateTime("30/05/2023"));
            MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,Convert.ToDateTime("30/04/2023"));
            MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,Convert.ToDateTime("30/10/2023"));
            MedicineDetails medicine5=new MedicineDetails("Povidin Iodin",10,50,Convert.ToDateTime("30/10/2023"));
            OrderDetails order1=new OrderDetails("UID1001","MD101",3,15,Convert.ToDateTime("13/05/2022"),OrderStatus.Purchased);
            OrderDetails order2=new OrderDetails("UID1001","MD102",2,10,Convert.ToDateTime("13/05/2022"),OrderStatus.Cancelled);
            OrderDetails order3=new OrderDetails("UID1001","MD104",2,100,Convert.ToDateTime("13/05/2022"),OrderStatus.Purchased);
            OrderDetails order4=new OrderDetails("UID1002","MD103",3,120,Convert.ToDateTime("15/05/2022"),OrderStatus.Cancelled);
            OrderDetails order5=new OrderDetails("UID1002","MD105",5,250,Convert.ToDateTime("15/05/2022"),OrderStatus.Purchased);
            OrderDetails order6=new OrderDetails("UID1002","MD102",3,15,Convert.ToDateTime("15/05/2022"),OrderStatus.Purchased);
            userList.Add(user1);
            userList.Add(user2);
            medicineList.Add(medicine1);
            medicineList.Add(medicine2);
            medicineList.Add(medicine3);
            medicineList.Add(medicine4);
            medicineList.Add(medicine5);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
            orderList.Add(order6);

        }
        public static void MainMenu()
        {
            int option;
            System.Console.WriteLine("-----WELCOME TO MEDICAL STORE----");
            do
            {

            
                System.Console.WriteLine("1.Registration\n2.Login\n3.OrderHistory\n4.Exit");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        OrderHistory();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Thank you!!!");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Option, Please Enter the correct one.");
                        break;
                    }
                }

            }while(option!=4);
        }
        private static void Registration()
        {
        
            
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your City: ");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your MobileNumber: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your AccountBalance: ");
            double balance=double.Parse(Console.ReadLine());

    

            Userdetails user=new Userdetails(name,age,city,mobileNumber,balance);
            userList.Add(user);
            System.Console.WriteLine("Your registration ID is : "+user.UserID);


            
        }

        private static void Login()
        {
            
            System.Console.WriteLine("Enter your UserID; ");
            string loggedUserID=Console.ReadLine().ToUpper();
            foreach(Userdetails user in userList)
            {
                if(loggedUserID.Equals(user.UserID))
                {
                    currentLoggedUser=user;
                    System.Console.WriteLine("StudentID exist");
                    SubMenu();
                    
                }
            }
            
        }
        private static void SubMenu()
        {
            char subOption;
            do
            {
                System.Console.WriteLine("a.Show medicine list");
                System.Console.WriteLine("b.Purchase medicine");
                System.Console.WriteLine("c.Cancel purchase");
                System.Console.WriteLine("d.Show purchase history");
                System.Console.WriteLine("e.Recharge");
                System.Console.WriteLine("f.Exit");
                System.Console.WriteLine("--PLEASE ENTER THE OPTION YOU NEED TO CHOOSE ");
                subOption=char.Parse(Console.ReadLine().ToLower());
                switch(subOption)
                {
                    case 'a':
                    {
                        ShowMedicineList();
                        break;
                    }
                    case 'b':
                    {
                        PurchaseMedicine();
                        break;
                    }
                    case 'c':
                    {
                        CancelPurchase();
                        break;
                    }
                    case 'd':
                    {
                        ShowPurcahseHistory();
                        break;
                    }
                    case 'e':
                    {
                        Recharge();
                        break;
                    }
                    case 'f':
                    {
                        System.Console.WriteLine("MAIN MENU"); //It will show the main menu
                        break;
                    }
                    default: 
                    {
                        System.Console.WriteLine("INVALID OPTION PLEASE ENTER THE CORRECT OPTION");
                        break;
                    }
                }
            }while(subOption!='f'); //untill the user enter the exit option, The loop continues.

        }
        private static void ShowMedicineList()
        {
            System.Console.WriteLine("----NOW YOU ARE SEEING THE MEDICINE LIST----");
            foreach (MedicineDetails medicine in medicineList)
            {
                
                System.Console.WriteLine($"MEDICINE ID [{medicine.MedicineID}] MEDICINE NAME [{medicine.MedicineName}] | Available count [{medicine.AvailableCount}] | PRICE [{medicine.Price}]");
            }
        }
        private static void PurchaseMedicine()
        {
            bool flag=true;
            ShowMedicineList();
            System.Console.WriteLine("ENTER THE MEDICINE ID WHICH YOU WANT TO BUY");
            string userMedicineID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter the count you need to buy: ");
            int userCount=int.Parse(Console.ReadLine());
            
            foreach (MedicineDetails medicine in medicineList)
            {
                if(userMedicineID.Equals(medicine.MedicineID))
                {
                    int medicineAmount=(userCount*medicine.Price);
                    if((medicine.AvailableCount>=userCount)&&(medicineAmount<=currentLoggedUser.Balance)&&(medicine.DateOfExpiry>DateTime.Now))
                    {
                        flag=false;
                        medicine.AvailableCount-=userCount;
                        currentLoggedUser.Balance-=medicineAmount;
                        OrderDetails order=new OrderDetails(currentLoggedUser.UserID,medicine.MedicineID,medicine.AvailableCount,medicine.Price,DateTime.Now,OrderStatus.Purchased);
                        orderList.Add(order);

                        System.Console.WriteLine("MEDICINE WAS PURCAHSED SUCCESSFULLY!!!");
                        System.Console.WriteLine("Your ORDER ID is "+order.OrderID);
                        
                        
                    }
                }
                
        
            }if (flag)
            {
                System.Console.WriteLine("Medicine id unavailable");
            }
            
        }
        private static void CancelPurchase()
        {

            foreach(OrderDetails order in orderList)
            {
                if((order.UserID==currentLoggedUser.UserID)&&(order.HolderOrderStatus==OrderStatus.Purchased))
                {
                    System.Console.WriteLine(order.UserID,order.MedicineID,order.MedicineCount,order.OrderDate,order.HolderOrderStatus);
                }
            }
            Console.WriteLine("Enter the order ID");
            string orderID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderID.Equals(orderID))
                {
                    if(order.HolderOrderStatus==OrderStatus.Purchased)
                    {
                        flag=false;
                        
                        foreach(MedicineDetails medicine in medicineList)
                        {
                            if(order.MedicineID.Equals(medicine.MedicineID))
                            {
                                medicine.AvailableCount=medicine.AvailableCount+order.MedicineCount;
                                
                            }
                        }
                        currentLoggedUser.Balance=currentLoggedUser.Balance+order.TotalPrice;
                        order.HolderOrderStatus=OrderStatus.Cancelled;
                        System.Console.WriteLine("Cancelled Sucessfully");
                        break;

                    }

                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid Order ID");
            }
            
        }
        private static void ShowPurcahseHistory()
        {
            foreach(OrderDetails order in orderList )
            {
                if(order.UserID.Equals(currentLoggedUser.UserID))
                {
                    System.Console.WriteLine($"Order ID is{order.OrderID} User ID is {order.UserID} medicineID is {order.MedicineID} medicine count is {order.MedicineCount} Totalprice is {order.TotalPrice} ordered date is {order.OrderDate} ordered status is {order.HolderOrderStatus}");

                }
            }
        }
        private static void Recharge()
        {
            System.Console.WriteLine("Entetr the amount you want to recharge");
            int amount=int.Parse(Console.ReadLine());
            currentLoggedUser.Balance+=amount;
            System.Console.WriteLine("ADDED SUCCESSFULLY");
            System.Console.WriteLine("YOUR BALANCE IS "+currentLoggedUser.Balance);

            
        }
        private static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                System.Console.WriteLine($"Ordre ID [{order.OrderID}] | userID  [{order.UserID}] | Medicine ID [{order.MedicineID}] | TotalPrice [{order.TotalPrice}] | OrderDate [{order.OrderDate}] | | OrderStatus [{order.HolderOrderStatus}] |  ");
            }
        }



        
        
    }
}