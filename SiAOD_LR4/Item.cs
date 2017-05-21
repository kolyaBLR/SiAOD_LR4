using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiAOD_LR4
{
    public class Item<T>
    {
        public Item() { }
        public Item(T item)
        {
            this.item = item;
        }
        public T item { get; set; }
        public Item<T> Next { get; set; }
        public Item<T> Back { get; set; }
    }
}