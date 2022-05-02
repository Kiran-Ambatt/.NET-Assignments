using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHandler
{
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
            //ex
        }
        public void pop()
        {
            if (top < 0)
            {
                return;
            }
            //Console.WriteLine(this.stack[top]);
            top--;
           
        }

        public void print()
        {
            for(int i = 0; i<top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
