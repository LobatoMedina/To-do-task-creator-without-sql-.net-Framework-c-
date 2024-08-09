using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.clases
{
    internal class PendingTask
    {
        private static Queue<Tareas> tasks = new Queue<Tareas>();
        public PendingTask() { }

        internal static Queue<Tareas> Tasks1 { get => tasks; set => tasks = value; }
        internal Queue<Tareas> Tasks { get => tasks; set => tasks = value; }
        public void InsertTask(Tareas t) {  tasks.Enqueue(t); }
        public Tareas RemoveTask() { 
            return tasks.Dequeue(); 
        }

    }
}
