﻿using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=int.Parse(Console.ReadLine());
        double []arr=new double[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=double.Parse(Console.ReadLine());
        }
        int j,small;
        for(int i=0;i<arr.Length-1;i++)
        {
            small=i;
            for(j=i+1;j<arr.Length;j++)
            {
                if(arr[j]<arr[small])
                {
                    small=j;
                }
            }
            double temp=arr[small];
            arr[small]=arr[i];
            arr[i]=temp;
            
            
        }
        foreach(double val in arr)
        {
            System.Console.WriteLine(val);
        }
    }
}