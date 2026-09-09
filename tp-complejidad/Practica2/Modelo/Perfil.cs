using Practica2.Base;
using Practica2.Patrones.Strategy;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Modelo
{
    public abstract class Perfil : IComparable
    {
        protected string nombre;
        protected int id;
        protected IEstrategiaComparacion estrategia;

        public Perfil(string n, int i)
        {
            this.nombre = n;
            this.id = i;
            this.estrategia = new PorId(); // Estrategia por defecto
        }

        public void setEstrategia(IEstrategiaComparacion e)
        {
            this.estrategia = e;
        }

        public string getNombre() => nombre;
        public int getId() => id;

        public virtual bool sosIgual(IComparable c) => estrategia.esIgual(this, c);
        public virtual bool sosMenor(IComparable c) => estrategia.esMenor(this, c);
        public virtual bool sosMayor(IComparable c) => estrategia.esMayor(this, c);

        public override string ToString() => $"[Perfil: Nombre={nombre}, ID={id}]";
    }
}