using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace appToDo.clases
{
    internal class ABBTask
    {
        private static NodoBin root;
        public ABBTask() {
            root = null;
        }
        public void Insertar(Tareas t)
        {
            if (root == null)
            {
                root = new NodoBin(t);
            }
            else
            {
                InsertarR(root,t);
            }

        }
        public void InsertarR(NodoBin rama, Tareas t) //rama me agarras
        {
            DateTime dateRoot = rama.dato.EndDate;
            DateTime actual = t.EndDate;
            if (DateTime.Compare(dateRoot, actual) >= 0) //compare retorna 1 si el valor 1 es mayor que el valor 2
            {// por lo tanto si la fecha de la raiz es mayor que la actual, la misma deberá ir a la izq.
                if (rama.izq == null)
                {
                    rama.izq = new NodoBin(t);
                }
                else
                {
                    InsertarR(rama.izq, t);
                }
            }
            else if (DateTime.Compare(dateRoot, actual) < 0)
            {
                if (rama.drch == null)
                {
                    rama.drch = new NodoBin(t);
                }
                else
                {
                    InsertarR(rama.drch, t);
                }
            }
        }
    }
}
