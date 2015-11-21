using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_PaulBoyko_PROG1197
{
    public class ToDoQueue
    {
        private List<ToDo> queue;          
        
        public List<ToDo> Queue
        {
            get { return this.queue; }
            set { this.queue = value; }
        } 

        public ToDo First
        {
            get
            {
                foreach (var first in this.queue)
                {
                    if (first.Next == null)
                        return first;
                }
                return new ToDo("No Tasks To Do", "");
            }        
                     
        }

        public ToDoQueue()
        {
            queue = new List<ToDo>();
        }

        public int Count()
        {
            var c = 0;
            foreach (ToDo first in this.queue)
            {
                c++;
            }
            return c;
        }

        public void Enqueue(ToDo newToDo)
        {
            if (newToDo != null)
            {
                if (queue.Count() == 0)
                {
                    //this.queue.Add(newToDo);
                }
                else
                {
                    var priorityLvl = queue.Where(q => q.Priority == newToDo.Priority);
                    if (priorityLvl.Any())
                    {
                        foreach (var td in priorityLvl)
                        {
                            var lastInPrior = priorityLvl.Where(t => t == td.Previous);
                            if (!lastInPrior.Any())
                            {
                                if (td.Previous != null)
                                {
                                    var newPrev = td.Previous;
                                    newToDo.Previous = newPrev;
                                    newToDo.Next = td;
                                    td.Previous = newToDo;
                                    newPrev.Next = newToDo;
                                    //queue.Add(newToDo);
                                }
                                else
                                {
                                    td.Previous = newToDo;
                                    newToDo.Next = td;
                                    //queue.Add(newToDo);
                                }
                            }
                        }
                    }

                }
                this.queue.Add(newToDo);
            }
        }

        public void Dequeue()
        {
            var newFirst = this.First.Previous;
            newFirst.Next = null;                        
            queue.Remove(this.First);
            //this.frst = newFirst;
        }

        public ToDo Peek()
        {
            return this.First;
        }
    }
}
