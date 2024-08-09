using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.clases
{
    internal class NodoBin
    {
        public Tareas dato;
        public NodoBin izq;
        public NodoBin drch;
        public NodoBin(Tareas t)
        {
            dato = t;
            izq = null;
            drch = null;
        }
    }
}
