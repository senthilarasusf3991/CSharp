
using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows: ");
            int row=int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter the column: ");
            int column=int.Parse(Console.ReadLine());

            int[,] arr=new int[row,column];
            for (int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    Console.WriteLine($"Element [{i}][{j}]");
                    arr[i,j]=int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("The matrix is: ");
            for(int i=0;i<row;i++)
            {
                for (int j=0;j<column;j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}