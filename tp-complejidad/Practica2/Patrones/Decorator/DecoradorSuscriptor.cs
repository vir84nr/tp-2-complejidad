using Practica2.Patrones.Observer;

namespace Practica2.Patrones.Decorator
{
    public abstract class DecoradorSuscriptor : IMostrable
    {
        protected IMostrable componente;

        public DecoradorSuscriptor(IMostrable componente)
        {
            this.componente = componente;
        }

        public abstract string mostrarInfo();

        public Suscriptor getSuscriptor() => componente.getSuscriptor();
    }
}