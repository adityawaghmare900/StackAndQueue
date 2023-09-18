namespace PeekAndPopStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStacPeekAndPop linkedListStacPeekAndPop = new LinkedListStacPeekAndPop();
            linkedListStacPeekAndPop.Push(56);
            linkedListStacPeekAndPop.Push(30);
            linkedListStacPeekAndPop.Push(70);
            linkedListStacPeekAndPop.Display();
            Console.WriteLine("========================================");

            linkedListStacPeekAndPop.Peek();
            Console.WriteLine("=========================================");

            linkedListStacPeekAndPop.Pop();
            Console.WriteLine("=========================================");

            Console.WriteLine("After Popped values are: ");
            linkedListStacPeekAndPop.Display();
        }
    }
}