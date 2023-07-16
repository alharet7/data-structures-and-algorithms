namespace stack_queue_pseudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue_pseudo queue_Pseudo = new Queue_pseudo();
            queue_Pseudo.Enqueue(1);
            queue_Pseudo.Enqueue(2);
            queue_Pseudo.Enqueue(3);
            queue_Pseudo.Enqueue(4);


            Console.WriteLine(queue_Pseudo.Dequeue());
            Console.WriteLine(queue_Pseudo.Dequeue());
            Console.WriteLine(queue_Pseudo.Dequeue());
            Console.WriteLine(queue_Pseudo.Dequeue());



            Console.ReadKey();
        }
    }
}