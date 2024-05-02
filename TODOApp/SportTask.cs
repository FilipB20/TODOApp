using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOApp
{
    internal class SportTask : Task
    {
        string Type;
        public SportTask(string name,string description,DateTime dueDate, string type) : base(name, description,dueDate)
        {
            Type = type;
        }
    }
}
