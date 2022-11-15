using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            ShiftDezire shift= new ShiftDezire("Petrol",5,"Black",40,450,30,"SD104","SEN11","SCN40");
            System.Console.WriteLine("----SHIFT DEZIRE DETAILS------");
            System.Console.WriteLine("---------BEFORE UPDATE------");
            shift.ShowDetails();
            shift.CalculateMilage();
            System.Console.WriteLine($"Milage is {shift.Milage}");
            System.Console.WriteLine("---------AFTER UPDATE------");
            shift.UpdateDetails("Petrol",7,"RED",40,380,25,"SD104","SEN11","SCN40");
            shift.ShowDetails();
            shift.showBrandDetails("Shift","Dezire");
            System.Console.WriteLine($"Brand Name is {shift.BrandName}");
            System.Console.WriteLine($"Model Name is {shift.ModelName}");
            shift.CalculateMilage();
            System.Console.WriteLine($"Milage is {shift.Milage}");



            Eco eco= new Eco("Disel",7,"Black",40,400,28,"EC104","EEN01","EC40");
            System.Console.WriteLine("------ECO DETAILS------");
            System.Console.WriteLine("---------BEFORE UPDATE------");
            eco.ShowDetails();
            eco.CalculateMilage();
            System.Console.WriteLine($"Milage is {eco.Milage}");
            System.Console.WriteLine("---------AFTER UPDATE------");
            eco.ShowDetails();
            eco.UpdateDetails("Disel",5,"White",40,250,15,"EC104","EEN01","EC40");
            eco.showBrandDetails("Eco","sport");
            System.Console.WriteLine($"Brand Name is {eco.BrandName}");
            System.Console.WriteLine($"Model Name is {eco.ModelName}");
            eco.CalculateMilage();
            System.Console.WriteLine($"Milage is {eco.Milage}");

            
        }
    }
}