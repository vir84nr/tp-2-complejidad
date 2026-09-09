using System;
using System.Collections.Generic;

namespace Practica2.Patrones.Observer
{
    public class Canal : IObservable
    {
        private string nombre;
        private List<IObservador> observadores = new List<IObservador>();

        public Canal(string n)
        {
            this.nombre = n;
        }

        public string getNombre() => nombre;

        public void publicarContenido()
        {
            Console.WriteLine($"{nombre} publicó contenido nuevo");
            notificarPublicacion();
        }

        public void iniciarEnVivo()
        {
            Console.WriteLine($"{nombre} está en vivo");
            notificarVivo();
        }

        public void agregarObservador(IObservador o) => observadores.Add(o);

        public void quitarObservador(IObservador o) => observadores.Remove(o);

        public void notificarPublicacion()
        {
            foreach (var o in observadores)
            {
                o.actualizarPublicacion();
            }
        }

        public void notificarVivo()
        {
            foreach (var o in observadores)
            {
                o.actualizarVivo();
            }
        }

        public List<IObservador> getObservadores() => observadores;
    }
}