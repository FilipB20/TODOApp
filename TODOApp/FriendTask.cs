using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOApp
{
    class FriendTask : Task
    {
        Friend friend;
        public FriendTask(string name,string description,DateTime dueDate,Friend friend) : base(name, description, dueDate)
        {
            this.friend = friend;
        }
    }
}
