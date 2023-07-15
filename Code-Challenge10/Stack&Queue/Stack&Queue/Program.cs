using Stack_Queue.Stacks_Queue;



namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new();

            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Pop();

            stack1.PrintStack();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("--Queue--");
            Console.WriteLine();


            Queue queue = new();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Dequeue();

            queue.PrintQueue();

            Console.ReadKey();
        }
    }
}