using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest.Models
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Next {get;set;}
        public Item<T> Prev { get; set; }

        public Item(T data)
        {
            Data = data;
        }
    }
}
