namespace stack_queue_animal_shelter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myqueue = new();
            myqueue.Enqueue(new Animals { Species = "cat", Name = "Antar" });
            myqueue.Enqueue(new Animals { Species = "cat", Name = "Namoor" });
            myqueue.Enqueue(new Animals { Species = "dog", Name = "bella" });
            var x = myqueue.Dequeue("dog");
            Console.WriteLine(myqueue.Print());
            Console.WriteLine($"Dequeued => {x.Name}  is a {x.Species}");

            Console.ReadKey();

        }
    }
}