using Practica2.Modelo;
using Practica2.Patrones.Decorator;
using System;


namespace Practica2.Patrones.Observer
{
    public class Suscriptor : Perfil, IObservador, IMostrable
    {
        private int mesesDeSuscripcion;
        private int horasVistas;
        private static Random random = new Random();

        public Suscriptor(string n, int i, int c, int h) : base(n, i)
        {
            this.mesesDeSuscripcion = c;
            this.horasVistas = h;
        }

        public int getMesesDeSuscripcion() => mesesDeSuscripcion;
        public int getHorasVistas() => horasVistas;

        public void verContenido()
        {
            Console.WriteLine("Viendo el nuevo contenido");
        }

        public void reaccionarANotificacion()
        {
            string[] reacciones = { "Abriendo la notificación", "Lo veo después", "Silenciando notificaciones" };
            Console.WriteLine(reacciones[random.Next(reacciones.Length)]);
        }

        public void actualizarPublicacion() => verContenido();

        public void actualizarVivo() => reaccionarANotificacion();

        // Implementación de IMostrable (Ejercicio 19)
        public string mostrarInfo() => $"{nombre} - {horasVistas} horas vistas";

        public Suscriptor getSuscriptor() => this;

        public override string ToString() =>
            $"[Suscriptor: {nombre}, ID: {id}, Meses: {mesesDeSuscripcion}, Horas: {horasVistas}]";
    }
}