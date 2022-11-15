using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        MarutiSwift maruti=new MarutiSwift(4,EngineType.Diesel,8000000,CarType.Sedan);
        System.Console.WriteLine("Maruti");
        maruti.GetCarType();
        maruti.GetEngineType();
        maruti.GetNoOfSeats();
        maruti.GetPrice();
        maruti.DisplayCarDetail();
        System.Console.WriteLine("Suzuki");
        SuzukiCiaz suzuki=new SuzukiCiaz(7,EngineType.Diesel,800000,CarType.SUV);
        System.Console.WriteLine("Suzuki");
        suzuki.GetCarType();
        suzuki.GetEngineType();
        suzuki.GetNoOfSeats();
        suzuki.GetPrice();
        suzuki.DisplayCarDetail();
    }
}