using System;
namespace StackDS;
class program
{
    public static void Main(string[] args)
    {
        Stack<int> stack=new Stack<int>();
        stack.push(5);
        stack.push(10);
        stack.push(15);
        stack.push(17);
        stack.push(20);
        System.Console.WriteLine(stack.Count);
        int temp=stack.Count;
        if(stack.Contains(5))
        {
            System.Console.WriteLine("Number is present");
        }
        else
        {
            System.Console.WriteLine("Number not present");
        }
        for(int i=0;i<temp;i++)
        {
            System.Console.WriteLine(stack.peek());
            System.Console.WriteLine(stack.pop());
        }
        
        
    }
}