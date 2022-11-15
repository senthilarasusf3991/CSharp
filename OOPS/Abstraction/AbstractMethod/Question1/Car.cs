namespace Question1
{
    public enum EngineType{Petrol,Diesel,CNG}
    public enum CarType{hatchback,Sedan,SUV}
    public abstract class Car
    {
        private static int _noOfWheels=4;
        private static int _noOfDoors=4;
        public EngineType EngineType { get; set; }
        public int NoOfSeats { get; set; }
        public int Price { get; set; }
        public CarType CarType { get; set; }
        public void ShowWheels()
        {
            System.Console.WriteLine($"No of Wheels :{_noOfWheels}");
        }
        public void ShowDoors()
        {
            System.Console.WriteLine($"No of Doors  :{_noOfDoors}");
        }
        public abstract EngineType GetEngineType();
        public abstract int GetNoOfSeats();
        public abstract int GetPrice();
        public abstract CarType GetCarType();
        public abstract void DisplayCarDetail();

        
        
        
    }
}