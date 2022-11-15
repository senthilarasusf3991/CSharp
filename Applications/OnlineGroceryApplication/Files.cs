using System;
using System.IO;
using System.Collections.Generic;
namespace OnlineGroceryStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineGroceryStore"))
            {
                System.Console.WriteLine("Folder not present");
                Directory.CreateDirectory("OnlineGroceryStore");
                System.Console.WriteLine("Folder Created successfully");
            }
            else
            {
                System.Console.WriteLine("Folder Existing");
            }
            if(!File.Exists("OnlineGroceryStore/BookingDetails.csv"))
            {
                System.Console.WriteLine("File not present");
                File.Create("OnlineGroceryStore/BookingDetails.csv");
                System.Console.WriteLine("File Created Successfully..");
            }
            else{
                System.Console.WriteLine("File already exist");
            }
            if(!File.Exists("OnlineGroceryStore/CustomerDetails.csv"))
            {
                System.Console.WriteLine("File not present.");
                File.Create("OnlineGroceryStore/CustomerDetails.csv");
                System.Console.WriteLine("File Created Successfully.");
            }
            else{
                System.Console.WriteLine("File Existing...");
            }
            if(!File.Exists("OnlineGroceryStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("File not present.");
                File.Create("OnlineGroceryStore/OrderDetails.csv");
                System.Console.WriteLine("File Created Successfully.");
            }
            else{
                System.Console.WriteLine("File Existing.");
            }
            if(!File.Exists("OnlineGroceryStore/ProductDetails.csv"))
            {
                System.Console.WriteLine("File not present....");
                File.Create("OnlineGroceryStore/ProductDetails.csv");
                System.Console.WriteLine("File Created Successfully.");
            }
            else{
                System.Console.WriteLine("File already Exist.");
            }
        }
        public static void WriteFiles()
        {
            string []bookingInfo=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookingInfo[i]=Operations.bookingList[i].BookingID+','+Operations.bookingList[i].CustomerID+','+Operations.bookingList[i].TotalPrice+','+Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+','+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("OnlineGroceryStore/BookingDetails.csv",bookingInfo);

            string []orderInfo=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderInfo[i]=Operations.orderList[i].OrderID+','+Operations.orderList[i].BookingID+','+Operations.orderList[i].ProductID+','+Operations.orderList[i].PurchaseCount+','+Operations.orderList[i].PriceOfOrder;

            }
            File.WriteAllLines("OnlineGroceryStore/OrderDetails.csv",orderInfo);

            string[]productInfo=new string[Operations.productList.Count];
            for (int i=0;i<Operations.productList.Count;i++)
            {
                productInfo[i]=Operations.productList[i].ProductID+','+Operations.productList[i].ProductName+','+Operations.productList[i].QuantityAvailable+','+Operations.productList[i].PricePerQuantity;

            }
            File.WriteAllLines("OnlineGroceryStore/ProductDetails.csv",productInfo);

            string []customerInfo=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
               customerInfo[i]=Operations.customerList[i].CustomerID+','+Operations.customerList[i].Name+','+Operations.customerList[i].FatherName+','+Operations.customerList[i].Gender+','+Operations.customerList[i].MobileNumber+','+Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+','+Operations.customerList[i].MailID+','+Operations.customerList[i].WalletBalance; 

            }
            File.WriteAllLines("OnlineGroceryStore/CustomerDetails.csv",customerInfo);
        }
        public static void ReadToFiles()
        {
            string[] bookingInfo = File.ReadAllLines("OnlineGroceryStore/BookingDetails.csv");
            foreach(string data in bookingInfo)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }
            string[] customerInfo=File.ReadAllLines("OnlineGroceryStore/CustomerDetails.csv");
            foreach(string data in customerInfo)
            {
                string []values=data.Split(',');
                CustomerRegistration customer=new CustomerRegistration(values[1],values[2],Enum.Parse<Gender>(values[3],true),long.Parse(values[4]),DateTime.ParseExact(values[5],"dd/MM/yyyy",null),values[6],double.Parse(values[7]));
                Operations.customerList.Add(customer);
            }
            string []orderInfo=File.ReadAllLines("OnlineGroceryStore/OrderDetails.csv");
            foreach(string data in orderInfo)
            {
                OrderDetails order=new OrderDetails(data);
                Operations.orderList.Add(order);
            }
            string []productInfo=File.ReadAllLines("OnlineGroceryStore/ProductDetails.csv");
            foreach(string data in productInfo)
            {
                ProductDetails product=new ProductDetails(data);
                Operations.productList.Add(product);
            }
        }
    }
}