namespace QueueDS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(7);
            System.Console.WriteLine(queue.Dequeue());
            System.Console.WriteLine(queue.Dequeue());
        }
    }
}