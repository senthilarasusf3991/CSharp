
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int splcount=0;
            int numcount=0;
            int alpcount=0;
            char[] alpha={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] number={'1','2','3','4','5','6','7','8','9','0'};
            char[] spe={'~','!','@','#','$','%','^','&','*','(',')','_','+','-','=','`','[',']','{','}','|','|',';',':','"','<','>','?','/',',','.'};
            System.Console.WriteLine("Enter the string: ");
            string name=Console.ReadLine().ToLower();
            foreach(char names in name)
            {
                foreach(char alp in alpha)
                {
                    if (alp==names)
                    alpcount++;

                }
                foreach(char spl in spe)
                {
                    if (spl==names)
                    splcount++;

                }
                foreach(char num in number)
                {
                    if (num==names)
                    numcount++;

                }
                

            }
            System.Console.WriteLine($"number of alphabet {alpcount}");
            System.Console.WriteLine($"number of special character {splcount}");
            System.Console.WriteLine($"count of number {numcount}");

            
        }
    }
}
