namespace Question1
{
    public class ShiftDezire:Car,IBrands
    {
        public string MakingID{get;set;}
        public string EngineNumber{get;set;}
        public string ChasisNumber{get;set;}
        public string BrandName{get;set;}
        public string ModelName{get;set;}

        public ShiftDezire(string fuelType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven,double litresLoaded,string makingID,string engineNumeber,string chasisNumber):base( fuelType, numberOfSeats, color, tankCapacity, numberOfKmDriven, litresLoaded)
        {
            MakingID=makingID;
            EngineNumber=engineNumeber;
            ChasisNumber=chasisNumber;
            
        }
        public void showBrandDetails(string brandName,string modelName)
        {
            BrandName=brandName;
            ModelName=modelName;
        }
        public void UpdateDetails(string fuelType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven,double litresLoaded,string makingID,string engineNumeber,string chasisNumber)
        {
            FuelType=fuelType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
            

        }
        public void ShowDetails()
        {
            CalculateMilage();
            ShowCarDetails();
            System.Console.WriteLine($"MakingID is      :{MakingID}");
            System.Console.WriteLine($"EngineNumber is  :{EngineNumber}");
            System.Console.WriteLine($"ChasisNumber is  :{ChasisNumber}");
            
            

        }
    }
}