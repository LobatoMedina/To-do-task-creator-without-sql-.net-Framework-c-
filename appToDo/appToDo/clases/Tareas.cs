using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.clases
{
    internal class Tareas
    {
        private int id;
        private string name;
        private DateTime startDate;
        private DateTime endDate;

        public Tareas() { }

        public Tareas(int id, string name, DateTime startDate, DateTime endDate)
        {
            this.id = id;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
