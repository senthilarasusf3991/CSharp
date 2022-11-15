using System;
namespace TypeConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name=Console.ReadLine();
        
            Console.WriteLine("Enter Your Age: ");
            int age=int.Parse(Console.ReadLine());

             Console.WriteLine("Mobile num: ");
             long mobile=Convert.ToInt64(Console.ReadLine());


           
            Console.WriteLine("Mark of the subject1: ");
            int mark1=int.Parse(Console.ReadLine());
           
            Console.WriteLine("Mark of the subject2: ");
            int mark2=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Mark of the subject3: ");
            int mark3=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Grade: ");
            string grade=Console.ReadLine();

           
            Console.WriteLine("Enter Mail ID: ");
            string mailid=(Console.ReadLine());
            

            Console.WriteLine("Trainee Details Are: ");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Mobile: "+mobile);
            Console.WriteLine("Marks1 : "+mark1);
            Console.WriteLine("Marks2 : "+mark2);
            Console.WriteLine("Marks3 : "+mark3);
            Console.WriteLine("Total: "+(mark1+mark2+mark3));
            Console.WriteLine("Average: "+(mark1+mark2+mark3)/3);
            Console.WriteLine("Grade: "+grade);
            Console.WriteLine("Mail id: "+mailid);
          




            


            Console.ReadLine();


            



        }
    }
}