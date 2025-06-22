using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC13_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max_pochimons = 75;
            string[,] pochidex = new string[max_pochimons, 6];
            int cantidadRegistrados = 0;
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Menu Principal - Centro de Investigacion de Pochimons");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Pochimones Encontrados: " + cantidadRegistrados + "/75");
                Console.WriteLine("\n1. Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Información de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ingrese la opción deseada: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (cantidadRegistrados >= max_pochimons)
                        {
                            Console.WriteLine("\nNo se pueden registrar más Pochimons. Presione Enter para continuar.");
                            Console.ReadLine();
                        }

                        Console.Write("\nIngrese el nombre del Pochimon: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                        string tipo = Console.ReadLine().ToUpper();
                        Console.Write("Ingrese el nivel del Pochimon: ");
                        string nivel = Console.ReadLine();

                        pochidex[cantidadRegistrados, 0] = nombre;
                        pochidex[cantidadRegistrados, 1] = tipo;
                        pochidex[cantidadRegistrados, 2] = nivel;
                        pochidex[cantidadRegistrados, 3] = "0"; // Estado
                        pochidex[cantidadRegistrados, 4] = "0"; // Investigador

                        cantidadRegistrados++;

                        Console.WriteLine("\nPochimon registrado correctamente. Presione Enter para continuar.");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("\nPochimons no investigados:");
                        Console.WriteLine("| Fila | Nombre       | Tipo | Nivel |");

                        for(int i = 0; i < cantidadRegistrados; i++)
                        {
                            if (pochidex[i,3] == "0")
                            {
                                Console.WriteLine("| " + i + "    | " + pochidex[i, 0] + "\t| " + pochidex[i, 1] + "   | " + pochidex[i, 2] + "    |");
                            }
                        }

                        Console.Write("\nIngrese el número de fila del Pochimon a asignar: ");
                        int fila = int.Parse(Console.ReadLine());

                        if (pochidex[fila,3] != "0")
                        {
                            Console.WriteLine("Ese pochimon no esta disponible. Presione Enter.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Ingrese el codigo del Investigador: ");
                            string investigador = Console.ReadLine();
                            pochidex[fila, 4] = investigador;
                            pochidex[fila, 3] = "1";
                            Console.WriteLine("Investigador asignado. Precione enter.");
                            Console.ReadLine();
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nPochimons registrados:");
                        Console.WriteLine("| Fila | Nombre       | Nivel |");

                        for(int i = 0; i < cantidadRegistrados; i++)
                        {
                            Console.WriteLine("| " + i + "    | " + pochidex[i, 0] + "\t| " + pochidex[i, 2] + "    |");
                        }
                        Console.Write("\nIngrese el número de fila del Pochimon a actualizar: ");
                        fila = int.Parse(Console.ReadLine());
                        int nivelActual = int.Parse(pochidex[fila, 2]);
                        int aumento = random.Next(1, 4);
                        pochidex[fila,2] = (nivelActual + aumento).ToString(); //ToString pasa cualquier tipo de valor entero a texto
                        Console.WriteLine("\nNivel actualizado en +" + aumento + ". Presione Enter.");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("\nPochimons en investigación:");
                        Console.WriteLine("| Fila | Nombre       | Tipo | Nivel | Estado | Investigador |");

                        for(int i = 0; i < cantidadRegistrados; i++)
                        {
                            if (pochidex[i,3] == "1")
                            {
                                Console.WriteLine("| " + i + "    | " + pochidex[i, 0] + "\t| " + pochidex[i, 1] + "   | " + pochidex[i, 2] + "    | " + pochidex[i, 3] + "      | " + pochidex[i, 4] + "            |");
                            }
                        }
                        Console.Write("\nIngrese el número de fila a marcar como investigado: ");
                        fila = int.Parse(Console.ReadLine());
                        pochidex[fila, 3] = "2";
                        Console.WriteLine("\nPochimon marcado como investigado. Presione Enter.");
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine("\n| Fila | Nombre       | Tipo | Nivel | Estado | Investigador |");

                        for(int i = 0;i < cantidadRegistrados; i++)
                        {
                            Console.WriteLine("| " + i + "    | " + pochidex[i, 0] + "\t| " + pochidex[i, 1] + "   | " + pochidex[i, 2] + "    | " + pochidex[i, 3] + "      | " + pochidex[i, 4] + "            |");
                        }
                        Console.WriteLine("\nPresione Enter para continuar.");
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.Write("\nIngrese el tipo de Pochimon a buscar (A/F/P): ");
                        string tipoBuscado = Console.ReadLine().ToUpper();
                        Console.WriteLine("\n| Fila | Nombre       | Tipo | Nivel |");
                        
                        for(int i = 0; i < cantidadRegistrados; i++)
                        {
                            if (pochidex[i,1] == tipoBuscado)
                            {
                                Console.WriteLine("| " + i + "    | " + pochidex[i, 0] + "\t| " + pochidex[i, 1] + "   | " + pochidex[i, 2] + "    |");
                            }
                        }
                        Console.WriteLine("\nPresione Enter para continuar.");
                        Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese el codigo del investigador: ");
                        string cod = Console.ReadLine();
                        Console.WriteLine("\n| Fila | Nombre       | Tipo | Nivel |");

                        for(int i = 0;i < cantidadRegistrados; i++)
                        {
                            if (pochidex[i, 4] == cod)
                            {
                                Console.WriteLine("| " + i + "    | " + pochidex[i, 0] + "\t| " + pochidex[i, 1] + "   | " + pochidex[i, 2] + "    |");
                            }
                        }
                        Console.WriteLine("\nPresione Enter para continuar.");
                        Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine("\nPochimons Picados (nivel > 30):");
                        Console.WriteLine("| Fila | Nombre       | Tipo | Nivel |");

                        for(int i = 0; i  < cantidadRegistrados; i++)
                        {
                            int nivelconvertido = int.Parse(pochidex[i,2]);
                            if(nivelconvertido > 30)
                            {
                                Console.WriteLine("| " + i + "    | " + pochidex[i, 0] + "\t| " + pochidex[i, 1] + "   | " + pochidex[i, 2] + "    |");
                            }
                        }
                        Console.WriteLine("\nPresione Enter para continuar.");
                        Console.ReadLine();
                        break;

                    case "9":
                        continuar = false;
                        break;
                }
            }
        }
    }
}
