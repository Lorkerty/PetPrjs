using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest.Models
{
    class LinkedStack<T>
    {
        private Item<T> head;
        public int Count = 0;

        public LinkedStack() { }

        public LinkedStack(T data)
        {
            SetHeadItem(data);
        }
        private void SetHeadItem(T data)
        {
            Item<T> item = new Item<T>(data);
            head = item;

            Count = 1;
        }
        public void Push(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return; 
            }   
            var item = new Item<T>(data)
            {
                Next = head
            };
            head = item;
            Count++;
        }
        public T Pop()
        {
            var data = head.Data;
            var current = head;
            var previous = head.Prev;
            while(current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            previous.Next = null;
            Count--;
            return data;
            
        }
        public T Peak()
        {
            return head.Data;
        }
    }
}
