using System;
namespace Question6;
public delegate bool FilterDelegate(float percentange);
class program
{
    

    public static bool CheckEligibility(float percentange)
    {
        if(percentange>=75)
        {
            return true;
        }
        return false;
    }
    public static void Eligibility(string str, FilterDelegate filter, float mark)
    {
        if(filter(mark))
        {
            System.Console.WriteLine(str);
            System.Console.WriteLine("You are eligible");
        }
        else{
            System.Console.WriteLine("You are not eligible");
        }
    }
    public static void Main(string[] args)
    {
        Eligibility ("senthil",CheckEligibility,98);
    }

}