using System;
using System.Collections.Generic;
namespace EcomApplication;
class Program
{
    public static void Main(string[] args)
    {
        Operations.OrderDefaultData();
        Operations.CustomerDefaultData();
        Operations.ProductDefaultData();
        Operations.MainMenu();
    }
}