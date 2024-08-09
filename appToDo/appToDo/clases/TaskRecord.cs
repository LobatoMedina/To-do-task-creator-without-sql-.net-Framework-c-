using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.clases
{
    internal class TaskRecord
    {
        private static Stack<Tareas> record;

        internal static Stack<Tareas> Record { get => record; set => record = value; }

        public TaskRecord()
        {
        }

        public void InsertTask(Tareas t)
        {
            record.Push(t);
        }
        public Tareas[] ReturnArray()
        {
            Tareas[] tareas = new Tareas[record.Count];
            foreach (var t in record) { 
                tareas[record.Count] = t;
            }
            return tareas;
        }
        public Tareas LastTask()
        {
            return record.Pop();
        }

    }
}
