using Practica2.Base;
using Practica2.Modelo;
using Practica2.Patrones.Observer;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Patrones.Strategy
{
    public class PorNombre : IEstrategiaComparacion
    {
        public bool esIgual(IComparable a, IComparable b) => string.Compare(((Perfil)a).getNombre(), ((Perfil)b).getNombre()) == 0;
        public bool esMenor(IComparable a, IComparable b) => string.Compare(((Perfil)a).getNombre(), ((Perfil)b).getNombre()) < 0;
        public bool esMayor(IComparable a, IComparable b) => string.Compare(((Perfil)a).getNombre(), ((Perfil)b).getNombre()) > 0;
    }

    public class PorId : IEstrategiaComparacion
    {
        public bool esIgual(IComparable a, IComparable b) => ((Perfil)a).getId() == ((Perfil)b).getId();
        public bool esMenor(IComparable a, IComparable b) => ((Perfil)a).getId() < ((Perfil)b).getId();
        public bool esMayor(IComparable a, IComparable b) => ((Perfil)a).getId() > ((Perfil)b).getId();
    }

    public class PorHorasVistas : IEstrategiaComparacion
    {
        public bool esIgual(IComparable a, IComparable b) => ((Suscriptor)a).getHorasVistas() == ((Suscriptor)b).getHorasVistas();
        public bool esMenor(IComparable a, IComparable b) => ((Suscriptor)a).getHorasVistas() < ((Suscriptor)b).getHorasVistas();
        public bool esMayor(IComparable a, IComparable b) => ((Suscriptor)a).getHorasVistas() > ((Suscriptor)b).getHorasVistas();
    }

    public class PorMesesSuscripcion : IEstrategiaComparacion
    {
        public bool esIgual(IComparable a, IComparable b) => ((Suscriptor)a).getMesesDeSuscripcion() == ((Suscriptor)b).getMesesDeSuscripcion();
        public bool esMenor(IComparable a, IComparable b) => ((Suscriptor)a).getMesesDeSuscripcion() < ((Suscriptor)b).getMesesDeSuscripcion();
        public bool esMayor(IComparable a, IComparable b) => ((Suscriptor)a).getMesesDeSuscripcion() > ((Suscriptor)b).getMesesDeSuscripcion();
    }
}