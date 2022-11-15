using System.IO;
using System;

namespace CafeteriaCardManagement
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("CafeteriaCardManagement"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("CafeteriaCardManagement");
            }
            else{
                System.Console.WriteLine("Folder exist");
            }
            if(!File.Exists("CafeteriaCardManagement/CartItem.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("CafeteriaCardManagement/CartItem.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }
            if(!File.Exists("CafeteriaCardManagement/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("CafeteriaCardManagement/FoodDetails.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }
            if(!File.Exists("CafeteriaCardManagement/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("CafeteriaCardManagement/OrderDetails.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }
            if(!File.Exists("CafeteriaCardManagement/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("CafeteriaCardManagement/UserDetails.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already Exist");
            }
        }
        public static void Write()
        {
            string[] cartItem=new string[Operations.cartItemList.Count];
            for(int i=0;i<Operations.cartItemList.Count;i++)
            {
                //ItemID,OrderID,FoodID,OrderPrice,OrderQuantity
                cartItem[i]=Operations.cartItemList[i].ItemID+','+Operations.cartItemList[i].OrderID+','+Operations.cartItemList[i].FoodID+','+Operations.cartItemList[i].OrderPrice+','+Operations.cartItemList[i].OrderQuantity;

            }
            File.WriteAllLines("CafeteriaCardManagement/CartItem.csv",cartItem);

            string[] foodDetails=new string[Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                //FoodID,FoodName,FoodPrice,AvailableQuantity
                foodDetails[i]=Operations.foodList[i].FoodID+','+Operations.foodList[i].FoodName+','+Operations.foodList[i].FoodPrice+','+Operations.foodList[i].AvailableQuantity;

            }
            File.WriteAllLines("CafeteriaCardManagement/FoodDetails.csv",foodDetails);

            string[] orderDetails=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
               //OrderID,UserID,OrderDate.ToString("dd/MM/yyyy"),TotalPrice,OrderStatus
                orderDetails[i]=Operations.orderList[i].OrderID+','+Operations.orderList[i].UserID+','+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+','+Operations.orderList[i].TotalPrice+','+Operations.orderList[i].OrderStatus;

            }
            File.WriteAllLines("CafeteriaCardManagement/OrderDetails.csv",orderDetails);

            string[] userDetails=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                //UserID,Name,FatherName,Gender,MobileNumber,MailID,WorkstationNumber,WalletBalance
                userDetails[i]=Operations.userList[i].UserID+','+Operations.userList[i].Name+','+Operations.userList[i].FatherName+','+Operations.userList[i].Gender+','+Operations.userList[i].MobileNumber+','+Operations.userList[i].MailID+','+Operations.userList[i].WorkstationNumber+','+Operations.userList[i].WalletBalance;

            }
            File.WriteAllLines("CafeteriaCardManagement/UserDetails.csv",userDetails);
        }
        public static void Read()
        {
            string[] cartItemInfo=File.ReadAllLines("CafeteriaCardManagement/CartItem.csv");
            foreach(string data in cartItemInfo)
            {
                string[] values=data.Split(',');
                CartItem newCart=new CartItem(values[1],values[2],double.Parse(values[3]),int.Parse(values[4]));
                Operations.cartItemList.Add(newCart);
            }

            string[] foodInfo=File.ReadAllLines("CafeteriaCardManagement/FoodDetails.csv");
            foreach(string data in foodInfo)
            {
                string[] values=data.Split(',');
                FoodDetails newFood=new FoodDetails(values[1],double.Parse(values[2]),int.Parse(values[3]));
                Operations.foodList.Add(newFood);
            }

            string[] orderInfo=File.ReadAllLines("CafeteriaCardManagement/OrderDetails.csv");
            foreach(string data in orderInfo)
            {
                string[] values=data.Split(',');
                OrderDetails newOrder=new OrderDetails(values[1],DateTime.Parse(values[2]),double.Parse(values[3]),Enum.Parse<OrderStatus>(values[4]));
                Operations.orderList.Add(newOrder);
            }
            string[] userInfo=File.ReadAllLines("CafeteriaCardManagement/UserDetails.csv");
            foreach(string data in userInfo)
            {
                string[] values=data.Split(',');
                UserDetails newUser=new UserDetails(values[1],values[2],Enum.Parse<Gender>(values[3]),long.Parse(values[4]),values[5],values[6],double.Parse(values[7]));
                Operations.userList.Add(newUser);
            }
        }
    }
}