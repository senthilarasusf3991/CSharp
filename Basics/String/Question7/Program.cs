
using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int vcount=0;
            int ccount=0;
            char[] vowels={'a','e','i','o','u'};
            char[] consonants={'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
            
            System.Console.WriteLine("Enter the string: ");
            string name=Console.ReadLine().ToLower();
            foreach(char names in name)
            {
                foreach(char vow in vowels)
                {
                    if (names == vow)
                    {
                        vcount++;
                    }  
                }
                foreach(char con in consonants)
                {
                    if (names == con)
                    {
                        ccount++;
                    }  
                }
                


                   
            }
            System.Console.WriteLine($"total number of vowel {vcount}");
            System.Console.WriteLine($"total number of vowel {ccount}");
            
        }
    }
}