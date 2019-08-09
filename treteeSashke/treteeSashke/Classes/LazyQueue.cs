using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treteeSashke
{
   public class LazyQueue<T>
    {
        private List<T> items = new List<T>();

        private T Head => items.Last();
        private T Tail => items.First();

        public int Count() => items.Count;
        public LazyQueue() { }

        public LazyQueue(T data)
        {
            items.Add(data);
        }
        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }
        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }
        public T Peak()
        {
            return Head; 
        }
    }
}
