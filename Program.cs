using System;

namespace stackSample
{
    class Program
    {
        static readonly int MAX = 5;
        int top;
        int[] stack = new int[MAX];

        public Program()
        {
            top = -1;
        }
               
        public bool Push(int item)
        {
            try
            {
                stack[++top] = item;
                Console.WriteLine("item pushed is:{0}", stack[top]);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Stack Overflow: {0}",ex);
                return false;
            }
            
        }

        public int Pop()
        {
            try
            {
                int value = stack[top--];
                Console.WriteLine("a value is popped, and the top value is :{0}", stack[top]);
                return value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stack Underflow:{0}",ex);
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program myStack = new Program();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            int value = myStack.Pop();
            Console.WriteLine("the value popped :{0}", value);
            myStack.Push(50);
            myStack.Push(60);
            myStack.Push(70);
            Console.ReadLine();
        }
    }
}
