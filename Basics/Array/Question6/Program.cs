
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size: ");
            size=int.Parse(Console.ReadLine());
            int []arr=new int [size];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter the number: ");
                arr[i]=int.Parse(Console.ReadLine());

            }
            bool check;
            int temp;
            for(int i=0;i<arr.Length;i++)
            {
                check=true;
                for (int j=0;j<arr.Length-1;j++)
                {
                    if(arr[i]<arr[j])
                    {
                        check=false;
                        temp=arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }

                }
                if(check)
                {
                    break;
                }
            }
            Console.WriteLine("Elements in ascending order: ");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
           
                


        }
    }
}
