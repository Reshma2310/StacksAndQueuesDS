using System;

namespace StacksAndQueuesDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StackLinkedList stack = new StackLinkedList();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
        }
    }
}