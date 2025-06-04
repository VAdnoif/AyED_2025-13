using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC13_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salud = 100, hambre = 50, energia = 70, dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();

            while (sigueVivo)
            {
                Console.WriteLine("Día {0} – ¿Qué querés hacer?",dia);
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");
                Console.Write("Elija una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        hambre += 20;
                        energia -= 15;

                        int probComidaMala = rand.Next(1, 101);
                        if (probComidaMala <= 30)
                        {
                            salud -= 15;
                            Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                        }
                        else
                        {
                            Console.WriteLine("Encontraste comida y te alimentaste.");
                        }
                        dia++;
                        break;

                    case "2":
                        energia += 30;
                        hambre -= 10;
                        Console.WriteLine("Dormiste y recuperaste energía.");
                        dia++;
                        break;

                    case "3":
                        energia -= 20;
                        hambre -= 15;

                        int probPlanta = rand.Next(1, 101);
                        if (probPlanta <= 50)
                        {
                            salud += 10;
                            Console.WriteLine("¡Encontraste una planta curativa! Salud +10.");
                        }
                        else
                        {
                            Console.WriteLine("Exploraste la isla pero no encontraste nada útil.");
                        }
                        dia++;
                        break;

                    case "4":
                        Console.WriteLine("Estado del personaje:");
                        Console.WriteLine("Salud: {0}",salud);
                        Console.WriteLine("Hambre: {0}",hambre);
                        Console.WriteLine("Energía: {0}",energia);
                        Console.WriteLine("Día: {0}",dia);
                        break;

                    case "5":
                        Console.WriteLine("Saliste del juego.");
                        sigueVivo = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intentá de nuevo.");
                        break;
                }

                if (opcion != "4" && opcion != "5")
                {
                    if (salud <= 0 || hambre <= 0 || energia <= 0)
                    {
                        Console.WriteLine("Te desmayaste y no pudiste sobrevivir.");
                        sigueVivo = false;
                    }
                }
            }





        }
    }
}
