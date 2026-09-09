using System.Collections.Generic;
using Practica2.Base;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Patrones.Iterator
{
    public class IteradorLista : IIterador
    {
        private List<IComparable> elementos;
        private int posicion;

        public IteradorLista(List<IComparable> lista)
        {
            this.elementos = lista;
            this.posicion = 0;
        }

        public void primero() => posicion = 0;
        public void siguiente() => posicion++;
        public bool fin() => posicion >= elementos.Count;
        public IComparable actual() => elementos[posicion];
    }

    public class IteradorCatalogo : IIterador
    {
        private IIterador iteradorPila;
        private IIterador iteradorCola;

        public IteradorCatalogo(IIterador p, IIterador c)
        {
            this.iteradorPila = p;
            this.iteradorCola = c;
            this.primero();
        }

        public void primero()
        {
            iteradorPila.primero();
            iteradorCola.primero();
        }

        public void siguiente()
        {
            if (!iteradorPila.fin())
                iteradorPila.siguiente();
            else
                iteradorCola.siguiente();
        }

        public bool fin() => iteradorPila.fin() && iteradorCola.fin();

        public IComparable actual()
        {
            if (!iteradorPila.fin())
                return iteradorPila.actual();
            return iteradorCola.actual();
        }
    }
}