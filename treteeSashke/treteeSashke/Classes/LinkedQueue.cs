﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treteeSashke
{
    public class LinkedQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;

        public int Count { get; private set; }
        public LinkedQueue() { }

        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            Item<T> item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }
            var item = new Item<T>(data)
            {
                Next = tail
            };
            tail = item;
            Count++;

        }
        public T Dequeue()
        {
            var data = head.Data;
            var current = tail.Next;
            var previous = tail;
            while(current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            tail.Next = null;
            Count--;
            return data;
        }
        public T Peak()
        {
            return head.Data;
        }
    }    
}
