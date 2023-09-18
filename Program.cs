namespace CreateStack_UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(56);
            linkedListStack.push(30);
            linkedListStack.push(70);
            Console.WriteLine("============================");
            Console.WriteLine("elements are: ");
            linkedListStack.display();
        }
    }
}