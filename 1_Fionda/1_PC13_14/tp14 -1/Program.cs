using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp14__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jugador1";
            int salud = 100, monedas = 50, enemigosDerrotados = 0;
            bool tieneEspada = false, salida = false;

            Console.WriteLine("Simulador Gamer");

            while(salida == false)
            {
                Console.WriteLine("1. Mostrar estado del jugador");
                Console.WriteLine("2. Encontrar espada magica");
                Console.WriteLine("3. Pelear contra un enemigo");
                Console.WriteLine("4. Comprar pocion de vida (vale 20 monedas)");
                Console.WriteLine("5. Salir del juego");
                Console.WriteLine("Seleccione una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Los valores actuales son: nombre: {0}, salud: {1}, monedas: {2}, enemigos derrotados: {3}, tiene espada: {4}", nombre, salud, monedas, enemigosDerrotados, tieneEspada);
                        Console.WriteLine();
                        break;
                    case "2":
                        if(tieneEspada == true)
                        {
                            Console.WriteLine("Ya tenes la espada magica");
                        }
                        else
                        {
                            Console.WriteLine("¡Encontraste la espada magica!");
                            tieneEspada = true;
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        if (tieneEspada == true)
                        {
                            salud -= 10;
                            enemigosDerrotados++;
                            Console.WriteLine("Ganaste la batalla! Salud -10");
                        }
                        else
                        {
                            salud -= 30;
                            Console.WriteLine("Fue una pelea dura sin espada! Salud -30");
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        if (monedas >= 20)
                        {
                            monedas -= 20;
                            salud += 20;
                            Console.WriteLine("Usaste una pocion. +20 de salud");
                        }
                        else
                        {
                            Console.WriteLine("No tenes suficientes monedas");
                        }
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("¡Gracias por jugar!");
                        salida = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Elegi una opcion del 1 al 5");
                        break;
                }

            }
        }
    }
}
