using System;
namespace Question2;
public delegate bool FilterDeligate(int numbers);
class program
{
    public static bool IsGreater(int numbers)
    {
        if(numbers>=50)
        {
            return true;
        }
        return false;
    }
    // public static bool ISLesser(int numbers)
    // {
    //     if(numbers<50)
    //     {
    //         return true;
    //     }
    //     return false;
    // }
    public static void CheckNumbers(FilterDeligate filter,int []arr)
    {
        for (int i=0;i<arr.Length;i++)
        {
            if(filter(arr[i]))
            {
                System.Console.WriteLine($"Greater than 50 is{arr[i]}");
            }
            else
        {
            System.Console.WriteLine($"lesser than 50 is {arr[i]}");
        }
        }
        
    }
    public static void Main(string[] args)
    {
        int[] arr= {45,33,22,66,43,77,88,55,52,90,33};

        CheckNumbers(IsGreater,arr);
    }
}