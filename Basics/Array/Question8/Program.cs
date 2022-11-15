
using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The first matrix: ");
            Console.Write("Enter the row: ");
            int row1=int.Parse(Console.ReadLine());

            Console.Write("Enter the column: ");
            int column1=int.Parse(Console.ReadLine());

            int [,]arr1=new int[row1,column1];
            for (int i=0;i<row1;i++)
            {
                for (int j=0;j<column1;j++)
                {
                    Console.Write("Element [i][j] ");
                    arr1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The second matrix: ");
            Console.Write("Enter the row: ");
            int row2=int.Parse(Console.ReadLine());

            Console.Write("Enter the column: ");
            int column2=int.Parse(Console.ReadLine());

            int [,]arr2=new int[row2,column2];
            for (int i=0;i<row2;i++)
            {
                for (int j=0;j<column2;j++)
                {
                    Console.Write("Elements [i][j] ");
                    arr2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The first matrix is: ");
            for (int i=0;i<row1;i++)
            {
                for (int j=0;j<column1;j++)
                {
                    Console.Write($"{arr1[i,j]} ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("The second matrix is: ");
            for (int i=0;i<row2;i++)
            {
                for (int j=0;j<column2;j++)
                {
                    Console.Write($"{arr2[i,j]} ");

                }
                Console.WriteLine();
            }
            //addtion
            Console.WriteLine("The Addtion of two matrix is: ");
            int [,]add=new int[row1,column1];
            for (int i=0;i<row1;i++)
            {
                for (int j=0;j<column1;j++)
                {
                    add[i,j]=arr1[i,j]+arr2[i,j];
                    Console.Write(add[i,j]+" ");

                }
                Console.WriteLine();
            }



        }
    }
}