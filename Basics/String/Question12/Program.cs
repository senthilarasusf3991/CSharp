
using System;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            string number=Console.ReadLine();
            string[] splita=number.Split(' ');

            int min,max;

            min = int.Parse(splita[0]);
            max = int.Parse(splita[0]);
            foreach(string item in splita)
            {
                if(min>int.Parse(item))
                min=int.Parse(item);
                if(max<int.Parse(item))
                max=int.Parse(item);
            }
            System.Console.WriteLine("Minimum : "+min);
            System.Console.WriteLine("Maximum : "+max);
        }
    }
}