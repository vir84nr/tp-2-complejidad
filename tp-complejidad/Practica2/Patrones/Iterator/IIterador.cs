using Practica2.Base;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Patrones.Iterator
{
    public interface IIterador
    {
        void primero();
        void siguiente();
        bool fin();
        IComparable actual();
    }
}