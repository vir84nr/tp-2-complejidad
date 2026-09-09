using System.Collections.Generic;
using Practica2.Base;
using Practica2.Patrones.Iterator;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Estructuras
{
    public class Cola : IColeccionable
    {
        private List<IComparable> elementos = new List<IComparable>();

        public int cuantos() => elementos.Count;

        public void encolar(IComparable e) => elementos.Add(e);

        public IComparable desencolar()
        {
            IComparable e = elementos[0];
            elementos.RemoveAt(0);
            return e;
        }

        public void agregar(IComparable c) => encolar(c);

        public IComparable minimo()
        {
            if (elementos.Count == 0) return null;
            IIterador iter = crearIterador();
            iter.primero();
            IComparable min = iter.actual();

            for (; !iter.fin(); iter.siguiente())
            {
                if (iter.actual().sosMenor(min)) min = iter.actual();
            }
            return min;
        }

        public IComparable maximo()
        {
            if (elementos.Count == 0) return null;
            IIterador iter = crearIterador();
            iter.primero();
            IComparable max = iter.actual();

            for (; !iter.fin(); iter.siguiente())
            {
                if (iter.actual().sosMayor(max)) max = iter.actual();
            }
            return max;
        }

        public bool contiene(IComparable c)
        {
            IIterador iter = crearIterador();
            for (iter.primero(); !iter.fin(); iter.siguiente())
            {
                if (iter.actual().sosIgual(c)) return true;
            }
            return false;
        }

        public IIterador crearIterador() => new IteradorLista(elementos);
    }
}