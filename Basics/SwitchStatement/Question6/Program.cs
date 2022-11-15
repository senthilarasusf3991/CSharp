
using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the radius: ");
            double radius=double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("1.area 2.perimeter 3.diameter");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {

                    double area=3.14*radius*radius;
                    System.Console.WriteLine($"Area is {area}");
                    break;
                }
                case 2:
                {
                    double perimeter=2*3.14*radius;
                    System.Console.WriteLine($"perimeter is {perimeter}");
                    break;
                    
                }
                case 3:
                {
                    double diameter=2*radius;
                    System.Console.WriteLine($"diameter is {diameter}");
                    break;
                    
                }
                default:
                {
                    System.Console.WriteLine("invalid input");
                    break;
                }
            }
            
        }
    }
}