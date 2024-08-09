using appToDo.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appToDo.Catalogos
{
    internal class CatalogoListasLigadas
    {
        private static ArrayList listaLigadas = new ArrayList();

        public ListaLigada getListaLigada(Tareas t)
        {
            foreach(ListaLigada x in listaLigadas)
            {
                if (x.Cabeza.Equals(t)) return x;
            }
            return null;
        }

        public void AñadirListaL(ListaLigada l)
        {
            listaLigadas.Add(l);
        }
        public void eliminarListaL(ListaLigada l)
        {
            listaLigadas.Remove(l);
        }
    }
}
