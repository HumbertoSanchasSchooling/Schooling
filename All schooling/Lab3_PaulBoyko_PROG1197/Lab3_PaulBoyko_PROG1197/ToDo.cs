using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_PaulBoyko_PROG1197
{
    public class ToDo
    {
        private string toDo;
        private string priority;
        private ToDo next;
        private ToDo prev;

        public string ThingToDo
        {
            get { return this.toDo; }
            set { this.toDo = value; }
        }

        public string Priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }

        public ToDo Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public ToDo Previous
        {
            get { return this.prev; }
            set { this.prev = value; }
        }

        public ToDo(string td, string prior)
        {
            toDo = td;
            priority = prior;
            next = null;
            prev = null;
        }             
    }
}
