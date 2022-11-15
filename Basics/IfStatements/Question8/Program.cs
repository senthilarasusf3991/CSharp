using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter sugarlevel: ");
            int sugarlevel=int.Parse(Console.ReadLine());
            if (sugarlevel<90)
            {
                Console.WriteLine($"{sugarlevel} is Low nsugar");

            }
            else if (sugarlevel>=90 && sugarlevel<130)
            {
                Console.WriteLine($"{sugarlevel} is Normal");
            }
            else if (sugarlevel>=130 && sugarlevel<140)
            {
                Console.WriteLine($"{sugarlevel} is medium");
            }
            else if (sugarlevel>=140 && sugarlevel<=170)
            {
                Console.WriteLine($"{sugarlevel} is High sugar - Try to reduce");
            }
            else
            {
                Console.WriteLine($"{sugarlevel} is You are a very high sugar patient");
            }
        }
    }
}