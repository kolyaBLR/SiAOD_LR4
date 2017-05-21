using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiAOD_LR4
{
    public class MyStack<T>
    {
        private Item<T> stack;
        public int Count { get; set; }

        public MyStack() { stack = new Item<T>(); }

        public void Push(T newItem)
        {
            Item<T> local = new Item<T>(newItem);
            local.Back = stack;
            stack.Next = local;
            stack = local;
            Count++;
        }

        public T Peek()
        {
            return stack.item;
        }

        public T Pop()
        {
            T item = stack.item;
            stack = stack.Back;
            stack.Next = null;
            Count--;
            return item;
        }
    }
}