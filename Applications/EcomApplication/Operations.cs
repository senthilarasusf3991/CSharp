using System;
using System.Collections.Generic;
namespace EcomApplication
{
    public static class Operations
    {
        private static List<CustomerDetails> customerList=new List<CustomerDetails>(); 
        private static List<OrderDetails> orderList=new List<OrderDetails>(); 
        private static List<ProductDetails> productList=new List<ProductDetails>();
        private static CustomerDetails currentLoggedCustomer;
    public static void CustomerDefaultData()
    {
        CustomerDetails customer1 = new CustomerDetails("Ravi", "Chennai", 9885858588, 50000,"ravi@mail.com");
        customerList.Add(customer1);
        CustomerDetails customer2= new CustomerDetails("Baskaran", "Chennai", 9888475757,60000,"baskaran@mail.com");
        customerList.Add(customer2);
    }
    public static void ProductDefaultData()
    {
        ProductDetails product1= new ProductDetails("Mobile",10,10000,3);
        productList.Add(product1);
        ProductDetails product2= new ProductDetails("Tablet",05,15000,2);
        productList.Add(product2);
        ProductDetails product3= new ProductDetails("Camara",03,20000,4);
        productList.Add(product3);
        ProductDetails product4= new ProductDetails("iPhone",05,50000,6);
        productList.Add(product4);
        ProductDetails product5= new ProductDetails("Laptop",03,40000,3);
        productList.Add(product5);
    }
    public static void OrderDefaultData()
    {
        OrderDetails order1=new OrderDetails(20000,"PID101","CID1001",DateTime.Now,2,"ordered");
        orderList.Add(order1);
        OrderDetails order2=new OrderDetails(40000,"PID103","CID1002",DateTime.Now,2,"ordered");
        orderList.Add(order2);

    }
    public static void MainMenu()
    {
        int option;
        do
        {
            System.Console.WriteLine("1.Customer Reistration 2.Login 3.Exit");
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
                    
                    break;
                }
                default:
                {
                    Console.WriteLine("invlid enter Enter again");
                    break;
                }
            }
        }while(option!=3);
    }
    private static void Login()
    {
        string cID ;
        char subOption;
            
        System.Console.WriteLine("Enter your customer ID: ");
        cID= Console.ReadLine();
        foreach (CustomerDetails checkCustomerID in customerList)
        {
            
            if(cID.Equals(checkCustomerID.CustomerID))
            {
                currentLoggedCustomer=checkCustomerID;
                System.Console.WriteLine("User found ");
                do
                {
                    System.Console.WriteLine("a.Purchase b.Order History c.Cancel Order d.Wallet balance e.Exit");
                    subOption=char.Parse(Console.ReadLine().ToLower());
                    switch(subOption)
                    {
                        case 'a':
                        {
                            ShowPurchase();
                            Purchase();

                            break;
                        }
                        case 'b':
                        {
                            OrderHistory();
                            break;
                        }
                        case 'c':
                        {
                            CancelOrder();
                            break;
                        }
                        case 'd':
                        {
                            System.Console.WriteLine(currentLoggedCustomer.WalletBalance);
                            break;
                        }
                        case 'e':
                        {
                            break;
                        }
                        default :
                        {
                            System.Console.WriteLine("invalid choice enter the correct choice");
                            break;
                        }
                
                    }
                
                }while(subOption!='e');
                

            }

    
        }


    }
    private static  void Registration()
    {
        System.Console.WriteLine("Enter your name: ");
        string name=Console.ReadLine();
        Console.WriteLine("Enter the city: ");
        string city=Console.ReadLine();
        System.Console.WriteLine("Enter your mobile number: ");
        long mobileNum=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your wallet intitial balance: ");
        double walletBalance=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your mail id: ");
        string mailID=Console.ReadLine();
        

        CustomerDetails customer = new CustomerDetails(name,city,mobileNum,walletBalance,mailID);
        customerList.Add(customer);

        System.Console.WriteLine("Your customer id is: "+customer.CustomerID);



    }
    
    public static void ShowPurchase()
    {
        System.Console.WriteLine("|-----------------------------------------------------------------------------------------------------|");
        System.Console.WriteLine("|  Product ID  |  Product Name  |  Available Stock Quantity  |  Price/Quantity  |  Shipping Duration  |");
        foreach(ProductDetails product in productList)
        {
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|{0,-13}|{1,-16}|{2,-26}|{3,-18}|{4,-21}|",product.ProductID,product.ProductName,product.Stock,product.Price,product.ShippingDuration);
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------------------|");

        }

    }
    private static void Purchase()
    {
        
        System.Console.WriteLine("Enter your product ID: ");
        string ProID=Console.ReadLine();
        foreach(ProductDetails product in productList)
        {
            if (ProID.Equals(product.ProductID))
            {
                System.Console.WriteLine("Enter the count you wish: ");
                int count=int.Parse(Console.ReadLine());
                if(product.Stock>=count)
                {
                    int totalAmount=(count*product.Price)+50;
                    System.Console.WriteLine("The total amount is: "+totalAmount);
                    if(currentLoggedCustomer.WalletBalance>totalAmount)
                    {
                        
                        currentLoggedCustomer.WalletBalance=currentLoggedCustomer.WalletBalance-totalAmount;
                        System.Console.WriteLine(currentLoggedCustomer.WalletBalance);
                        product.Stock=product.Stock-count;
                        //System.Console.WriteLine(product.Stock);
                        System.Console.WriteLine("Your order is Placed,Your order will be delivered on "+DateTime.Today.AddDays(product.ShippingDuration).ToShortDateString());
                        OrderDetails orderDetails=new OrderDetails(totalAmount,ProID,currentLoggedCustomer.CustomerID,DateTime.Today,count,"ordered");
                        orderList.Add(orderDetails);

                    }
                    else{
                        System.Console.WriteLine("Insufficient wallet balance");
                    }
                }
                else{
                    System.Console.WriteLine($"Required Count is not Available , Current availability is{product.Stock}");
                }
            }
        } 
    }
    private static void OrderHistory()
    {
        System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
        System.Console.WriteLine("|  Customer ID  |  OrderID  |  Product ID  |  Total Price  |  Purchase Date  |  Quantity Purchased  |  Order Status  |");
        System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
        foreach(OrderDetails orderDetails in orderList)
        {
            if(orderDetails.CustomerID.Equals(currentLoggedCustomer.CustomerID))
            {
                System.Console.WriteLine("|{0,-13}|{1,-11}|{2,-11}|{3,-12}|{4,-15}|{5,-20}|{6,-14}",orderDetails.CustomerID,orderDetails.OrderId,orderDetails.ProductID,orderDetails.TotalPrice,orderDetails.PurchaseDate,orderDetails.Quantity,orderDetails.OrderStatus);
                System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
            }
        }
    }
    private static void CancelOrder()
    {
        System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
        System.Console.WriteLine("|  Customer ID  |  OrderID  |  Product ID  |  Total Price  |  Purchase Date  |  Quantity Purchased  |  Order Status  |");
        System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
        foreach(OrderDetails orderDetails in orderList)
        {
            if(orderDetails.CustomerID.Equals(currentLoggedCustomer.CustomerID))
            {
                System.Console.WriteLine("|{0,-13}|{1,-11}|{2,-11}|{3,-12}|{4,-15}|{5,-20}|{6,-14}",orderDetails.CustomerID,orderDetails.OrderId,orderDetails.ProductID,orderDetails.TotalPrice,orderDetails.PurchaseDate,orderDetails.Quantity,orderDetails.OrderStatus);
                System.Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
            }
        }
        System.Console.WriteLine("Enter the Order ID to be cancelled:");
        string orderID=Console.ReadLine();
        foreach(OrderDetails cancel in orderList)
        {
            if(cancel.OrderId==orderID)
            {
                cancel.OrderStatus="cancelled";
                System.Console.WriteLine(cancel.OrderStatus);
                foreach(ProductDetails product in productList)
                {
                    if(cancel.ProductID==product.ProductID)
                    {
                        product.Stock=product.Stock+cancel.Quantity;
                        System.Console.WriteLine(product.Stock);
                    }
                }
            }
            if(cancel.CustomerID==currentLoggedCustomer.CustomerID)
            {
                currentLoggedCustomer.WalletBalance=currentLoggedCustomer.WalletBalance+cancel.TotalPrice;
                System.Console.WriteLine(currentLoggedCustomer.WalletBalance);
            }

        }
    }
    

        


}

}
