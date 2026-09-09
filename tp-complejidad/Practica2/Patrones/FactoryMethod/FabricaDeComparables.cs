using Practica2.Base;
using Practica2.Patrones.FactoryMethod;
using IComparable = Practica2.Base.IComparable;

namespace Practica2.Patrones.FactoryMethod
{
    public abstract class FabricaDeComparables
    {
        public abstract IComparable crearAleatorio();
        public abstract IComparable crearPorTeclado();

        public static IComparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            if (opcion == 1) fabrica = new FabricaDeVisualizaciones();
            else if (opcion == 2) fabrica = new FabricaDeSuscriptores();

            return fabrica?.crearAleatorio();
        }

        public static IComparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            if (opcion == 1) fabrica = new FabricaDeVisualizaciones();
            else if (opcion == 2) fabrica = new FabricaDeSuscriptores();

            return fabrica?.crearPorTeclado();
        }
    }
}