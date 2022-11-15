﻿using System;
namespace MergeSort;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        string []arr=new string[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a string :");
            arr[i]=Console.ReadLine();
        }
        
        MergeSort(arr,0,arr.Length-1);
        foreach(string item in arr)
        {
            System.Console.WriteLine(item);
        }
    }
    public static void MergeArray(string[] array, int left, int middle, int right)
    {
        int leftArrayLength = middle - left + 1;
        int rightArrayLength = right - middle;
        string[] leftTempArray = new string[leftArrayLength];
        string[] rightTempArray = new string[rightArrayLength];
        int i, j;

        for (i = 0; i < leftArrayLength; ++i)
            leftTempArray[i] = array[left + i];
        for (j = 0; j < rightArrayLength; ++j)
            rightTempArray[j] = array[middle + 1 + j];

        i = 0;
        j = 0;
        int k = left;

        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftTempArray[i].CompareTo(rightTempArray[j])>=0)
            {
            array[k++] = leftTempArray[i++];
            }
            else
            {
            array[k++] = rightTempArray[j++];
            }
        }

        while (i < leftArrayLength)
        {
            array[k++] = leftTempArray[i++];
        }

        while (j < rightArrayLength)
        {
            array[k++] = rightTempArray[j++];
        }
    }
    static public void MergeSort(string[] arr, int p, int r) {
        if (p < r) {
        int q = (p + r) / 2;
        MergeSort(arr, p, q);
        MergeSort(arr, q + 1, r);
        MergeArray(arr, p, q, r);
        }
      }
}