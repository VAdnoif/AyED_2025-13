using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_7
{
    internal class Program
    {
        static string[] nombres = new string[20];
        static string[] sagas = new string[20];
        static int[] fuerzas = new int[20];
        static int[] defensas = new int[20];
        static bool[] esHeroe = new bool[20];
        static int cantidad = 0;
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n=== Borderlands Multiverse Manager ===");
                Console.WriteLine("1. Nuevo personaje");
                Console.WriteLine("2. Consultar personaje por nombre");
                Console.WriteLine("3. Modificar personaje");
                Console.WriteLine("4. Eliminar personaje");
                Console.WriteLine("5. Mostrar todos los personajes");
                Console.WriteLine("6. Salir");
                Console.Write("Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: NuevoPersonaje(); 
                            break;
                    case 2: ConsultarPersonaje(); 
                            break;
                    case 3: ModificarPersonaje(); 
                            break;
                    case 4: EliminarPersonaje(); 
                            break;
                    case 5: MostrarTodos(); 
                            break;
                    case 6: Console.WriteLine("Saliendo..."); 
                            break;
                    default: Console.WriteLine("Opción inválida."); 
                            break;
                }
            } while (opcion != 6);
        }

        static void NuevoPersonaje()
        {
            if (cantidad >= 20)
            {
                Console.WriteLine("No se pueden agregar más personajes (máximo 20).");
                return;
            }

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i] == nombre)
                {
                    Console.WriteLine("Ya existe un personaje con ese nombre.");
                    return;
                }
            }

            nombres[cantidad] = nombre;
            Console.Write("Ingrese saga/faccion: ");
            sagas[cantidad] = Console.ReadLine();
            Console.Write("Ingrese fuerza: ");
            fuerzas[cantidad] = int.Parse(Console.ReadLine());
            Console.Write("Ingrese defensa: ");
            defensas[cantidad] = int.Parse(Console.ReadLine());
            Console.Write("¿Es heroe? (s/n): ");
            esHeroe[cantidad] = Console.ReadLine().ToLower() == "s";

            cantidad++;
            Console.WriteLine("Personaje creado con exito.");
        }

        static void ConsultarPersonaje()
        {
            Console.Write("Ingrese nombre del personaje a consultar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i] == nombre)
                {
                    MostrarPersonaje(i);
                    return;
                }
            }
            Console.WriteLine("Personaje no encontrado.");
        }

       
        static void ModificarPersonaje()
        {
            Console.Write("Ingrese nombre del personaje a modificar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i] == nombre)
                {
                    Console.Write("Nueva fuerza: ");
                    fuerzas[i] = int.Parse(Console.ReadLine());
                    Console.Write("Nueva defensa: ");
                    defensas[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Personaje modificado.");
                    return;
                }
            }
            Console.WriteLine("Personaje no encontrado.");
        }

        
        static void EliminarPersonaje()
        {
            Console.Write("Ingrese nombre del personaje a eliminar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i] == nombre)
                {
                    
                    for (int j = i; j < cantidad - 1; j++)
                    {
                        nombres[j] = nombres[j + 1];
                        sagas[j] = sagas[j + 1];
                        fuerzas[j] = fuerzas[j + 1];
                        defensas[j] = defensas[j + 1];
                        esHeroe[j] = esHeroe[j + 1];
                    }
                    cantidad--;
                    Console.WriteLine("Personaje eliminado.");
                    return;
                }
            }
            Console.WriteLine("Personaje no encontrado.");
        }

        
        static void MostrarTodos()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay personajes en la lista.");
                return;
            }

            
            int[] indices = new int[cantidad];
            for (int i = 0; i < cantidad; i++) indices[i] = i;

            
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (string.Compare(nombres[indices[i]], nombres[indices[j]]) > 0)
                    {
                        int temp = indices[i];
                        indices[i] = indices[j];
                        indices[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n--- Lista de personajes ---");
            for (int i = 0; i < cantidad; i++)
            {
                MostrarPersonaje(indices[i]);
            }
        }

        
        static void MostrarPersonaje(int i)
        {
            Console.WriteLine($"Nombre: {nombres[i]}, Saga: {sagas[i]}, Fuerza: {fuerzas[i]}, Defensa: {defensas[i]}, Heroe: {esHeroe[i]}");
        }
    }
}
