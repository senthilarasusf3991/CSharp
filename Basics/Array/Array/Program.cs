using System;
namespace Aray
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] name=new string[5];
            int flag=0;
            int temp=0;
            for (int i=0;i<name.Length;i++)
            {
                Console.Write(" Enter your name: ");
                name[i]=Console.ReadLine();
                Console.WriteLine(name[i]);
                
               
            }
            
            Console.WriteLine("Enter the name you want to be searched: ");
            string search=Console.ReadLine();
            for (int i=0;i<name.Length;i++)
            {
                if (search==name[i])
                {
                    Console.WriteLine($"name is present @index{i}");
                    flag+=1;
                }

            }
            if (flag==0)
            {
                Console.WriteLine("name is not present");
            }
            

            foreach(string names in name)
            {
                Console.WriteLine(names);   

            }
            foreach(string names in name)
            {
               if (search==names)
                {
                    Console.WriteLine("name is present");
                    temp+=1;
                }

            }
            if (temp==0)
            {
                Console.WriteLine("name is not present");
            } 
            
            
            
          
        }
    }
}