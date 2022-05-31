using System;

namespace StacksAndQueuesDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*StackLinkedList stack = new StackLinkedList();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();*/
            Console.WriteLine("...Queue Started...");
            QueueLinkedList queue = new QueueLinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();
        }
    }
}