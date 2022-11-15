using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        ShiftDezire shift1=new ShiftDezire(){TankCapacity=4,FuelType=FuelType.Petrol,BrandName="Swift",ModelName="suv",NoOfKmDriven=47};
        shift1.CalculateMilage(47,4);
        
        System.Console.WriteLine("Before update");
        shift1.ShowDetails();
        System.Console.WriteLine("After Update");
        shift1.UpdateInfo(7);
        shift1.ShowDetails();
        ECO eco1=new ECO(){TankCapacity=6,FuelType=FuelType.Petrol,BrandName="Mustang",ModelName="suv",NoOfKmDriven=36};
        eco1.CalculateMilage(36,3);
        System.Console.WriteLine("Before update");
        eco1.ShowDetails();
        System.Console.WriteLine("AFter update");
        shift1.UpdateInfo(10);
        eco1.ShowDetails();

    }
}