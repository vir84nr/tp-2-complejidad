using System;

namespace Practica2.Auxiliares
{
    public class GeneradorDeDatosAleatorios
    {
        private static Random random = new Random();

        public int numeroAleatorio(int max)
        {
            return random.Next(0, max + 1);
        }

        public string stringAleatorio(int cant)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] stringChars = new char[cant];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(stringChars);
        }
    }
}