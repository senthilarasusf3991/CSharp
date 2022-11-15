namespace Question2
{
    public class LadiesWear:Dress
    {
        public override DressType DressType{get;set;}
        public override string Name{get;set;}
        public override int TotalPrice{get;set;}
        public LadiesWear(string name,int totalPrice,DressType dressType)
        {
            Name=name;
            TotalPrice=totalPrice;
            DressType=dressType;
        }
        public override void GetDressInfo()
        {
            System.Console.WriteLine($"Name is       :{Name}");
            System.Console.WriteLine($"TotalPrice is  :{TotalPrice}");
            System.Console.WriteLine($"DressType is  :{DressType}");
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"FinalPrice is   :{(TotalPrice-(TotalPrice*0.20))}");
        }
    }
}