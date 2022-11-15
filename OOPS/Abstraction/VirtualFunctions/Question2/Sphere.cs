namespace Question2
{
    public class Sphere:Dimension
    {
        public double Volume{get;set;}
        public double Radius { get; set; }
        public Sphere(int value1,int value2,double radius):base(value1,value2)
        {
            Radius=radius;
        }
        public override void Calculate()
        {
            Volume=4*3.14*Radius*Radius;
        }
        
        public override void Display()
        {
            System.Console.WriteLine($"Volume   :{Volume}");
        }
    }
}