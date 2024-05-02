using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOApp
{
    internal class SchoolTask : Task
    {
        string Course;
        
        public SchoolTask(string name,string description,DateTime dueDate,string course) : base(name, description, dueDate)
        {
            Course = course;
        }
    }
}
