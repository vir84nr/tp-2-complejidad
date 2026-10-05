using System;
using Practica2.Base;
using Practica2.Estructuras;
using Practica2.Patrones.Decorator;
using Practica2.Patrones.FactoryMethod;
using Practica2.Patrones.Iterator;
using Practica2.Patrones.Observer;
using Practica2.Patrones.Strategy;
using IComparable = Practica2.Base.IComparable;

namespace Practica2
{
    public class Program
    {
        // Ejercicio 2 / Modificado
        public static void llenarSuscriptores(IColeccionable coleccionable)
        {
            FabricaDeSuscriptores fabrica = new FabricaDeSuscriptores();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.agregar(fabrica.crearAleatorio());
            }
        }

        // Ejercicio 6
        public static void imprimirElementos(IColeccionable coleccionable)
        {
            IIterador iter = coleccionable.crearIterador();
            for (iter.primero(); !iter.fin(); iter.siguiente())
            {
                Console.WriteLine(iter.actual());
            }
            Console.WriteLine();
        }

        // Ejercicio 8
        public static void cambiarEstrategia(IColeccionable coleccionable, IEstrategiaComparacion estrategia)
        {
            IIterador iter = coleccionable.crearIterador();
            for (iter.primero(); !iter.fin(); iter.siguiente())
            {
                if (iter.actual() is Suscriptor s)
                {
                    s.setEstrategia(estrategia);
                }
            }
        }

        // Ejercicio 9
        public static void informar(IColeccionable coleccionable)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos());
            Console.WriteLine("Minimo: " + coleccionable.minimo());
            Console.WriteLine("Maximo: " + coleccionable.maximo());
            Console.WriteLine();
        }

        // Ejercicio 14
        public static void llenarFactory(IColeccionable coleccionable, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                coleccionable.agregar(FabricaDeComparables.crearAleatorio(opcion));
            }
        }

        public static void informarFactory(IColeccionable coleccionable, int opcion)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos());
            Console.WriteLine("Minimo: " + coleccionable.minimo());
            Console.WriteLine("Maximo: " + coleccionable.maximo());

            IComparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
            if (coleccionable.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
            Console.WriteLine();
        }

        // Ejercicio 18
        public static void temporadaDeContenido(Canal canal)
        {
            for (int i = 0; i < 5; i++)
            {
                canal.publicarContenido();
                canal.iniciarEnVivo();
            }
        }

        // Ejercicio 7
        public static void mainEjercicio7()
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            Playlist playlist = new Playlist();
            llenarSuscriptores(pila);
            llenarSuscriptores(cola);
            llenarSuscriptores(playlist);
            imprimirElementos(pila);
            imprimirElementos(cola);
            imprimirElementos(playlist);
        }

        // Ejercicio 9
        public static void mainEjercicio9()
        {
            Pila pila = new Pila();
            llenarSuscriptores(pila);
            cambiarEstrategia(pila, new PorNombre());
            informar(pila);
            cambiarEstrategia(pila, new PorMesesSuscripcion());
            informar(pila);
            cambiarEstrategia(pila, new PorHorasVistas());
            informar(pila);
            cambiarEstrategia(pila, new PorId());
            informar(pila);
        }

        // Ejercicio 14
        public static void mainEjercicio14()
        {
            Pila pila = new Pila();
            int opcion = 2; // 1 = Visualizaciones, 2 = Suscriptores
            llenarFactory(pila, opcion);
            informarFactory(pila, opcion);
        }

        // Ejercicio 18
        public static void mainEjercicio18()
        {
            Canal canal = FabricaDeCanales.crearAleatorio();
            for (int i = 0; i < 20; i++)
            {
                Suscriptor s = (Suscriptor)FabricaDeComparables.crearAleatorio(2);
                canal.agregarObservador(s);
            }
            temporadaDeContenido(canal);
        }



        public static void mainEjercicio22()
        {
            Console.WriteLine("=== EJECUCION DE LA PRACTICA 2 (EJERCICIO 22 - INTEGRACION) ===");

            // Ejercicio 22: Combina Observer, FactoryMethod y Decorator
            Canal canal = new Canal("CTYPDS UNAJ");

            // Crear 10 suscriptores mediante la fábrica y agregarlos como observadores
            for (int i = 0; i < 10; i++)
            {
                Suscriptor s = (Suscriptor)FabricaDeComparables.crearAleatorio(2); // 2 = Suscriptor
                canal.agregarObservador(s);
            }

            // Simular temporada de contenido
            Console.WriteLine("\n--- INICIO DE TEMPORADA ---");
            temporadaDeContenido(canal);

            // Imprimir cada suscriptor aplicando la cadena de decoradores (Ejercicio 21 / 22)
            Console.WriteLine("\n--- LISTA DE SUSCRIPTORES CON DECORADORES ---");
            foreach (IObservador obs in canal.getObservadores())
            {
                if (obs is Suscriptor s)
                {
                    IMostrable decorado = new DecoradorAntiguedad(s);
                    decorado = new DecoradorFanatico(decorado);
                    decorado = new DecoradorEstadoCuenta(decorado);
                    decorado = new DecoradorRecuadro(decorado);

                    Console.WriteLine(decorado.mostrarInfo());
                    Console.WriteLine();
                }
            }
        }
        public static void Main(string[] args)
        {
            // pofe para probar hay que dejar sin comentar solo el ejercicio que queres probar
            //mainEjercicio7();
            // mainEjercicio9();
             //mainEjercicio14();
           // mainEjercicio18();
           mainEjercicio22();
            Console.WriteLine("Presioná una tecla para salir...");
            Console.ReadKey();
        }
    }
}
