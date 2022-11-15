using System;
namespace Question7;
public delegate bool FilterDelegate(float percentage);
class program
{
        public static bool MBBS(float percentage)
        {
            if(percentage>=95)
            {
                return true;
            }
            return false;
        }
        public static bool BE(float percentage)
        {
            if(percentage>=60)
            {
                return true;
            }
            return false;
        }
        public static bool BDS(float percentage)
        {
            if(percentage>=90)
            {
                return true;

            }
            return false;
        }
        public static bool BtechAgri(float percentage)
        {
            if(percentage>=80)
            {
                return true;

            }
            return false;
        }
        public static void Elegibility(string str, FilterDelegate filter, float mark)
        {
            System.Console.WriteLine(str);
            if(filter(mark))
            {
                
                System.Console.WriteLine("You are eligile");
            }
            else{
                System.Console.WriteLine("Not eligible");
            }
        }

        public static void Main(string[] args)
        {
            Elegibility ("senthil",BtechAgri,89);

            Elegibility ("Arun", BE, 50);
        }
}