using Practica2.Auxiliares;
using Practica2.Patrones.Observer;

namespace Practica2.Patrones.FactoryMethod
{
    public class FabricaDeCanales
    {
        private static GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

        public static Canal crearAleatorio()
        {
            return new Canal("Canal_" + generador.stringAleatorio(4));
        }
    }
}