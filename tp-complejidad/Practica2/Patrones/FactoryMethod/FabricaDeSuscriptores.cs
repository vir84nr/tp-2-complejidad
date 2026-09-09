using Practica2.Auxiliares;
using Practica2.Base;
using Practica2.Patrones.Observer;
using Practica2.Patrones.Strategy;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Patrones.FactoryMethod
{
    public class FabricaDeSuscriptores : FabricaDeComparables
    {
        private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        private LectorDeDatos lector = new LectorDeDatos();

        public override IComparable crearAleatorio()
        {
            string nombre = generador.stringAleatorio(5);
            int id = generador.numeroAleatorio(99999);
            int meses = generador.numeroAleatorio(60);
            int horas = generador.numeroAleatorio(500);

            Suscriptor s = new Suscriptor(nombre, id, meses, horas);
            s.setEstrategia(new PorHorasVistas());
            return s;
        }

        public override IComparable crearPorTeclado()
        {
            string nombre = lector.stringPorTeclado();
            int id = lector.numeroPorTeclado();
            int meses = lector.numeroPorTeclado();
            int horas = lector.numeroPorTeclado();

            Suscriptor s = new Suscriptor(nombre, id, meses, horas);
            s.setEstrategia(new PorHorasVistas());
            return s;
        }
    }
}