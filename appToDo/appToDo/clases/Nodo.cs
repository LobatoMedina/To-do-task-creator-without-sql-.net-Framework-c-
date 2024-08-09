using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.clases
{
    internal class Nodo
    {
        private Nodo Siguiente;
        private Tareas dato;
        public Nodo(Tareas d) {
            Siguiente = null;
            dato = d;
        }

        internal Nodo Siguiente1 { get => Siguiente; set => Siguiente = value; }
        internal Tareas Dato { get => dato; set => dato = value; }
    }
}
