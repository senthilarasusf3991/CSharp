namespace Question2
{
    public class CylinderCalculator:Calculator
    {
        public int Radius{get;set;}
        public int Height{get;set;}
        public CylinderCalculator(int radius,int height)
        {
            Radius=radius;
            Height=height;
        }
        public sealed override void Area()
        {
            System.Console.WriteLine("Cylinder Area is "+(3.14*Radius*Radius));
        }
        public sealed override void Volume()
        {
            System.Console.WriteLine("Cylinder Volume is  "+(3.14*Radius*Radius*Height));
        }
    }
}