using System;
namespace Question1
{
    public class AreaCalculator
    {
        public int  Radius { get; set; }
        public double Area { get; set; }
        public AreaCalculator(int radius)
        {
            Radius=radius;
        }
        public virtual void Calculate()
        {
            Area=3.14*Radius*Radius;
            System.Console.WriteLine($"Area is :{Area}");
        }
        public virtual void Display()
        {
            System.Console.WriteLine($"Area    :{Area}");
            System.Console.WriteLine($"Radius  :{Radius}");
        }
        
    }
}