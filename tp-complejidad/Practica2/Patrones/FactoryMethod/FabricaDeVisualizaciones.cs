using Practica2.Auxiliares;
using Practica2.Base;
using Practica2.Modelo;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Patrones.FactoryMethod
{
    public class FabricaDeVisualizaciones : FabricaDeComparables
    {
        private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        private LectorDeDatos lector = new LectorDeDatos();

        public override IComparable crearAleatorio()
        {
            return new Visualizacion(generador.numeroAleatorio(10000));
        }

        public override IComparable crearPorTeclado()
        {
            int cantidad = lector.numeroPorTeclado();
            return new Visualizacion(cantidad);
        }
    }
}