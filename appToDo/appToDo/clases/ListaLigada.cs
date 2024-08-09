using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.clases
{
    internal class ListaLigada
    {
        private  Nodo cabeza;

        internal Nodo Cabeza { get => cabeza; set => cabeza = value; }

        public ListaLigada()
        {
            cabeza = null;
        }
        public int returnSize()
        {
            if(cabeza == null) return 0;
            int contador = 0;
            Nodo actual = cabeza;
            while (actual.Siguiente1 != null)
            {
                actual = actual.Siguiente1;
                contador++;
            }
            return contador;

        }
        public void InsertarTarea(Tareas t)
        {
            Nodo nuevoNodo = new Nodo(t);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente1 != null)
                {
                    actual = actual.Siguiente1;
                }
                actual.Siguiente1 = nuevoNodo;
            }
        }
        public void EliminarTarea(Tareas t)
        {
            if(cabeza == null) return;
            if(cabeza.Dato == t)
            {
                cabeza = cabeza.Siguiente1;
            }
            Nodo actual = cabeza;
            while(actual.Siguiente1 != null && actual.Siguiente1.Dato != t)
            {
                actual = actual .Siguiente1;
            }
            if (actual.Siguiente1 != null)
            {
                actual.Siguiente1 = actual.Siguiente1.Siguiente1;
            }
        }
    }
}
