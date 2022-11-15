namespace Question1
{
    public class Car
    {
        public string FuelType{get;set;}
        public int NumberOfSeats{get;set;}
        public string Color{get;set;}
        public int TankCapacity{get;set;}
        public int NumberOfKmDriven{get;set;}
        public double LitresLoaded{get;set;}
        public double Milage{get;set;}
        public Car(string fuelType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven,double litresLoaded)
        {
            FuelType=fuelType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
            LitresLoaded=litresLoaded;
        }
        public void CalculateMilage()
        {
            Milage=NumberOfKmDriven/LitresLoaded;
            
            
        }
        public void ShowCarDetails()
        {
            System.Console.WriteLine($"FuelType is         :{FuelType}");
            System.Console.WriteLine($"NumberOfSeats is    :{NumberOfSeats}");
            System.Console.WriteLine($"Color is            :{Color}");
            System.Console.WriteLine($"TankCapacity is     :{TankCapacity}");
            System.Console.WriteLine($"NumberOfKmDriven is :{NumberOfKmDriven}");
            System.Console.WriteLine($"LitresLoaded is     :{LitresLoaded}");
            

        }
    }
}