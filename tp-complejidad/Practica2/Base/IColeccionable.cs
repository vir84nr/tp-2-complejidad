using Practica2.Patrones.Iterator;

namespace Practica2.Base
{
    public interface IColeccionable : IIterable
    {
        int cuantos();
        IComparable minimo();
        IComparable maximo();
        void agregar(IComparable c);
        bool contiene(IComparable c);
    }
}