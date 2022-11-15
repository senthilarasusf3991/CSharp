
using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the range: ");   
            int range=int.Parse(Console.ReadLine());
            Console.WriteLine("The even numbers are:");
            int i=1;
            while (i<range)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                    
                }
                i++; //increment
              
            }

            Console.WriteLine("Enter the range: ");
            int range1=int.Parse(Console.ReadLine());
            Console.WriteLine("The odd numbers are:");
            int j=1;
            while (j<range1)
            {
                if (j%2==1)
                {
                    System.Console.WriteLine(j);
                    
                }
                j++;  //for increment

            }
            
            System.Console.WriteLine(("Enter the range: "));
            range1=int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers are");
            j=3;
            int k=2;
            bool temp;
            while(j<range1)
            {
                
                temp=true;
                k=2;
                while (k<j)
                {
                    if (j%k==0)
                    {
                        temp=false;
                        break;
                    }
                    k++;
                }

               if(temp)
               {
                    Console.WriteLine(j);
               }  
               j++;
            }


        }
    }
}