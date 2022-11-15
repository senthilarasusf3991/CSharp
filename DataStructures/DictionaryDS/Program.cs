using System;
namespace DictionaryDS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int , string> myDictionary=new Dictionary<int, string>();
            myDictionary.Add(1,"senthil");
            myDictionary.Add(2,"arun");
            myDictionary.Add(1,"balu");
            System.Console.WriteLine(myDictionary[3]);
            foreach (KeyValuePair<int,string> value in myDictionary)
            {
                System.Console.WriteLine(value.Key);
                System.Console.WriteLine(value.value);
            }
        }
    }
}