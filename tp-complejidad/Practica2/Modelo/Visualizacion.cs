using Practica2.Base;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Modelo
{
    public class Visualizacion : IComparable
    {
        private int cantidad;

        public Visualizacion(int c)
        {
            this.cantidad = c;
        }

        public int getCantidad() => this.cantidad;

        public bool sosIgual(IComparable c) => c is Visualizacion v && this.cantidad == v.getCantidad();
        public bool sosMayor(IComparable c) => c is Visualizacion v && this.cantidad > v.getCantidad();
        public bool sosMenor(IComparable c) => c is Visualizacion v && this.cantidad < v.getCantidad();

        public override string ToString() => this.cantidad.ToString();
    }
}