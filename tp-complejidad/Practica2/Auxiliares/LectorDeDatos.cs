using System;

namespace Practica2.Auxiliares
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.Write("Ingrese un numero entero: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string stringPorTeclado()
        {
            Console.Write("Ingrese una cadena de texto: ");
            return Console.ReadLine();
        }
    }
}