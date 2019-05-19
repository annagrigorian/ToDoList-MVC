using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Services
{
    public class Item<T, TColor>
    {
        public T Id { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public TColor Color { get; set; }
    }
}
