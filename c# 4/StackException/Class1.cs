using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHandler
{
    public class StackFullException : Exception
    {
        public override string Message
        {
            get
            {
                return "Stack is full";
            }
        }
   

    }
    public class StackEmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "Stack is Empty";
            }
        }


    }
    class myArray
    {
        static readonly int MAX = 5;
        public int[] stack = new int[MAX];
        public int top = 0;

        public void push(int value)
        {
            if (top < MAX)
            {
                this.stack[top] = value;
                top++;
            }
            else
            {
                throw new StackFullException();
            }
            
        }
        public void pop()
        {
            if (top == 0)
            {
                throw new StackEmptyException();
            }
            else
            {
                top--;
            }
            
        }

        public void print()
        {
            for(int i = 0; i<top; i++)
            {
                Console.WriteLine("stack is:",stack[i]);
            }
        }
    }
}
