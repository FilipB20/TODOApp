using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOApp
{
    class Task
    {
        string Name { get; set; }
        string Description { get; set; }

        DateTime DueDate;

        public Task (string name, string description, DateTime dueDate)
        {
            Name = name;
            Description=description;
            DueDate=dueDate;
        }
    }
}
