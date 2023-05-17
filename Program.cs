using System;
using System.Collections.Generic;
using System.Text;
namespace Day_6_Stack_and_queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Peek();
            stack.Pop();
            stack.Display();

        }
    }
}