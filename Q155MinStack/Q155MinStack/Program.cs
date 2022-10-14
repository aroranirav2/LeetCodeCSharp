using System;
using System.Collections.Generic;

namespace Q155MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class MinStack
        {
            private readonly Stack<(int, int)> _stack;
            public MinStack()
            {
                _stack = new Stack<(int, int)>();
            }

            public void Push(int val)
            {
                _stack.Push((val, _stack.Count == 0 ? val : val < _stack.Peek().Item2 ? val : _stack.Peek().Item2));
            }

            public void Pop()
            {
                _stack.Pop();
            }

            public int Top()
            {
                return _stack.Peek().Item1;
            }

            public int GetMin()
            {
                return _stack.Peek().Item2;
            }
        }
    }
}
