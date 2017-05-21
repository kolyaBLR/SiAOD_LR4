using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiAOD_LR4
{
    public class Item<T>
    {
        public T Element { get; set; }
        public Item<T> Next { get; set; }
        public Item<T> Back { get; set; }
    }
}