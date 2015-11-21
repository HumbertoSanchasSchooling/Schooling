using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_PaulBoyko_PROG1197
{
    class Queue
    {
        private List<ToDo> priorityLvl;
        private string priorityLvlName;
        private Queue next;
        private Queue prev;
        private bool first;
        
        
        public List<ToDo> PriortyLevels
        {
            get { return this.priorityLvl; }
            set { this.priorityLvl = value; }
        } 

        public string PriorityLvlName
        {
            get { return this.priorityLvlName; }
            set { this.priorityLvlName = value; }
        }

        public Queue Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Queue Previous
        {
            get { return this.prev; }
            set { this.prev = value; }
        }

        public Queue (string pln)
        {
            priorityLvl = new List<ToDo>();
            priorityLvlName = pln;
            next = null;
            prev = null;
        }

        public void First()
        {
            foreach (ToDo first in this.priorityLvl)
            {
                if(first.Next == null)
                {
                    this.first = true;
                }
                else
                {
                    this.first = false;
                }                
            }                 
        }
    }
}
