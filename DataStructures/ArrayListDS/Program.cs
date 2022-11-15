using System;
namespace ArrayListDS;
class Program
{
    public static void Main(string[] args)
    {
        List<int>list1=new List<int>();
        list1.Add(10);
        list1.Add(20);
        list1.Add(30);
        list1.Add(25);
        list1.Add(31);
        
        //creating second list
        List<int>list2=new List<int>();
        list2.Add(11);
        list2.Add(22);
        list2.Add(30);
        list2.Add(55);
        list2.Add(21);
        list1.AddRange(list2);
        // for(int i=0;i<list1.Count;i++)
        // {
        //     System.Console.WriteLine(list1[i]);
        // }
        foreach(int value in list1)
        {
            System.Console.WriteLine(value);
        }
        
    }
}