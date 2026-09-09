using Practica2.Patrones.Observer;

namespace Practica2.Patrones.Decorator
{
    public interface IMostrable
    {
        string mostrarInfo();
        Suscriptor getSuscriptor();
    }
}