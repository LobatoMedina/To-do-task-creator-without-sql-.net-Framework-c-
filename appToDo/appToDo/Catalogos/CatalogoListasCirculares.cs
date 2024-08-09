using appToDo.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.Catalogos
{
    internal class CatalogoListasCirculares
    {
        private static ArrayList listaCircular = new ArrayList();

        public ListaLigadaCircular getListaCircular(Tareas t)
        {
            foreach (ListaLigadaCircular x in listaCircular)
            {
                if (x.Cabeza.Equals(t)) return x;
            }
            return null;
        }

        public void AñadirListaL(ListaLigadaCircular l)
        {
            listaCircular.Add(l);
        }
        public void eliminarListaL(ListaLigadaCircular l)
        {
            listaCircular.Remove(l);
        }
    }
}
