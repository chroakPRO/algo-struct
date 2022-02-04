using System;

namespace DataStructure
{
    public class StacksNQues
    {
        
    }

    internal class Queue
    {
        private static readonly int max = 1000;
        private int last;
        private int first;
        private int[] queue = new int[max];
        
        private bool isEmpty()
        {
            return (last <= 0);
        }
        
        private bool Enqueue(int data)
        {
            if (last >= max)
            {
                Console.WriteLine("Stack overflow.");
                return false;
            }
            else
            {
                queue[++last] = data;
                return true;
            }
        }

        private int Dequeue()
        {
            if (last <= 0 || first > last)
            {
                Console.WriteLine("Stack underflow");
                return 0;
            }
            else
            {
                int queuevalue = queue[++first];
                return 1;
            }
        }

        private void Peak()
        {
            
        }

        private void PrintQueue()
        {
            
        }
    }
    
    internal class Stack
    {
        private static readonly int max = 1000;
        private int top;
        private int[] stack = new int[max];

        private bool isEmpty()
        {
            return (top <= 0);
        }

        public Stack()
        {
            top = -1;
        }

        private bool Push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("Stack overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        private int Pop()
        {
            if (top <= 0)
            {
                Console.WriteLine("Stack underflow");
                return 0;
            }
            else
            {
                int popvalue = stack[top--];
                return popvalue;
            }
        }

        private void Peak()
        {
            if (top <= 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                Console.WriteLine($"This is the top in the stack ->  {stack[top]}");
            }
        }

        private void PrintStack()
        {
            if (top <= 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                for (int i = top; i <= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}