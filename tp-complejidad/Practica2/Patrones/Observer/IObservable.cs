namespace Practica2.Patrones.Observer
{
    public interface IObservable
    {
        void agregarObservador(IObservador o);
        void quitarObservador(IObservador o);
        void notificarPublicacion();
        void notificarVivo();
    }
}