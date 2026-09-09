using Practica2.Base;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Patrones.Strategy
{
    public interface IEstrategiaComparacion
    {
        bool esIgual(IComparable a, IComparable b);
        bool esMenor(IComparable a, IComparable b);
        bool esMayor(IComparable a, IComparable b);
    }
}