namespace Question1
{

    public class SuzukiCiaz:Car
    {
        public SuzukiCiaz(int noOfSeats,EngineType engineType,int price,CarType carType)
        {
            NoOfSeats=noOfSeats;
            EngineType=engineType;
            Price=price;
            CarType=carType;
        }
        public override EngineType GetEngineType()
        {
            return EngineType;
        }
        public override int GetPrice()
        {
            return Price;
        }
        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }
        public override CarType GetCarType()
        {
            return CarType;
        }
        public override void DisplayCarDetail()
        {
            System.Console.WriteLine($"CarType         :{CarType}");
            System.Console.WriteLine($"Price           :{Price}");
            System.Console.WriteLine($"NoOfSeats       :{NoOfSeats}");
            ShowDoors();
            ShowWheels();

        }
    }
}