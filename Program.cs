namespace Dequeue_UC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();

            Console.WriteLine("=========================================");
            linkedListQueue.Dequeue();

            linkedListQueue.Display();
        }
    }
}