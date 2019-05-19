using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoItemViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public string Color { get; set; }
    }
}
