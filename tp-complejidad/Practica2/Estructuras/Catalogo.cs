using Practica2.Base;
using Practica2.Patrones.Iterator;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Estructuras
{
    public class Catalogo : IColeccionable
    {
        private Pila pila;
        private Cola cola;

        public Catalogo(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int cuantos() => pila.cuantos() + cola.cuantos();

        public IComparable minimo()
        {
            IComparable minPila = pila.minimo();
            IComparable minCola = cola.minimo();

            if (minPila == null) return minCola;
            if (minCola == null) return minPila;

            return minPila.sosMenor(minCola) ? minPila : minCola;
        }

        public IComparable maximo()
        {
            IComparable maxPila = pila.maximo();
            IComparable maxCola = cola.maximo();

            if (maxPila == null) return maxCola;
            if (maxCola == null) return maxPila;

            return maxPila.sosMayor(maxCola) ? maxPila : maxCola;
        }

        public void agregar(IComparable c)
        {
            // No hace nada, según especificación del Ejercicio 8
        }

        public bool contiene(IComparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }

        public IIterador crearIterador()
        {
            return new IteradorCatalogo(pila.crearIterador(), cola.crearIterador());
        }
    }
}