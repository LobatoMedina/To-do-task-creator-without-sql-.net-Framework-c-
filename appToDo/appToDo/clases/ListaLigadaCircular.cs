using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.clases
{
    internal class ListaLigadaCircular
    {

        private  Nodo cabeza;
        private  Nodo cola;

        internal Nodo Cabeza { get => cabeza; set => cabeza = value; }

        public ListaLigadaCircular()
        {
            cabeza = null;
            cola = null;
        }

        public void Insertar(Tareas data)
        {
            Nodo nuevoNodo = new Nodo(data);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
                nuevoNodo.Siguiente1 = cabeza;
            }
            else
            {
                nuevoNodo.Siguiente1 = cabeza;
                cabeza = nuevoNodo;
                cola.Siguiente1 = cabeza;
            }
        }
        public void Eliminar(Tareas data)
        {
            if (cabeza == null) return;

            if (cabeza.Dato == data)
            {
                if (cabeza == cola)
                {
                    cabeza = null;
                    cola = null;
                }
                else
                {
                    cabeza = cabeza.Siguiente1;
                    cola.Siguiente1 = cabeza;
                }
                return;
            }
            Nodo actual = cabeza;
            do
            {
                if (actual.Siguiente1.Dato == data)
                {
                    if (actual.Siguiente1 == cola)
                    {
                        cola = actual;
                    }
                    actual.Siguiente1 = actual.Siguiente1.Siguiente1;
                    break;
                }
                actual = actual.Siguiente1;
            } while (actual != cabeza);
        }
        public void MostrarLista()
        { //pendiente
            if (cabeza == null) return;

            Nodo actual = cabeza;
            do
            {
                actual = actual.Siguiente1;
            } while (actual != cabeza);
        }
    }
}
