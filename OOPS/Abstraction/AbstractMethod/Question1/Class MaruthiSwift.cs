namespace Question1
{

    public class MarutiSwift:Car
    {
        public MarutiSwift(int NoOfSeats,EngineType engineType,int price,CarType carType)
        {
            this.NoOfSeats=NoOfSeats;
            EngineType=engineType;
            Price=price;
            CarType=carType;
        }
        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }
        public override EngineType GetEngineType()
        {
            return EngineType;
        }
        public override int GetPrice()
        {
            return Price;
        }
        public override CarType GetCarType()
        {
            return CarType;
        }
        public override void DisplayCarDetail()
        {
            System.Console.WriteLine($"CarType is       :{CarType}");
            System.Console.WriteLine($"Price is        :{Price}");
            System.Console.WriteLine($"NoOfSeats is    :{NoOfSeats}");
            ShowDoors();
            ShowWheels();

        }
    }
}