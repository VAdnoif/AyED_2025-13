using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_3
{
    internal class Program
    {
        const int max_encargos = 25;
        static string[,] encargos = new string[max_encargos, 5];
        static int cantidad_registrados = 0;

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("==== Argentinian Simulator ====");
                Console.WriteLine("1. Crear nuevo encargo");
                Console.WriteLine("2. Mostrar todos los encargos");
                Console.WriteLine("3. Asignar camión a encargo");
                Console.WriteLine("4. Mostrar encargos asignados");
                Console.WriteLine("5. Promedio de ganancia por sede");
                Console.WriteLine("6. Encargo con mayor distancia");
                Console.WriteLine("7. Filtrar encargos por código de camión");
                Console.WriteLine("8. Salir");
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": CrearEncargo(); break;
                    case "2": MostrarEncargos(); break;
                    case "3": AsignarCamion(); break;
                    case "4": MostrarAsignados(); break;
                    case "5": PromedioGanancia(); break;
                    case "6": EncargoMayorDistancia(); break;
                    case "7": FiltrarPorCamion(); break;
                    case "8": continuar = false; break;
                    default: Console.WriteLine("Opción no válida. Presione Enter."); break;
                }
            }
        }

        static void CrearEncargo()
        {
            if (cantidad_registrados >= max_encargos)
            {
                Console.WriteLine("\nNo se pueden ingresar más encargos.");
                return;
            }

            int distancia = 0;
            while (true)
            {
                Console.Write("Ingrese la distancia en km del encargo: ");
                if (int.TryParse(Console.ReadLine(), out distancia) && distancia > 0)
                    break;
                Console.WriteLine("Distancia inválida. Debe ser mayor a 0.");
            }

            string sede = "";
            while (true)
            {
                Console.Write("Ingrese la sede (1 = BSAS, 2 = BB, 3 = MDQ): ");
                sede = Console.ReadLine();
                if (sede == "1" || sede == "2" || sede == "3") break;
                Console.WriteLine("Sede inválida.");
            }

            Console.Write("Ingrese la ganancia esperada ($): ");
            string ganancia = Console.ReadLine();

            encargos[cantidad_registrados, 0] = "";             
            encargos[cantidad_registrados, 1] = distancia.ToString();
            encargos[cantidad_registrados, 2] = sede;
            encargos[cantidad_registrados, 3] = ganancia;
            encargos[cantidad_registrados, 4] = "0";          

            cantidad_registrados++;
            Console.WriteLine("Encargo registrado exitosamente.");
        }

        static void MostrarEncargos()
        {
            Console.WriteLine("\n| Fila | Codcamion | Distancia | Sede | Ganancia | Asignado |");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                Console.WriteLine($"| {i + 1} | {encargos[i, 0]} | {encargos[i, 1]} | {encargos[i, 2]} | {encargos[i, 3]} | {encargos[i, 4]} |");
            }
        }

        static void AsignarCamion()
        {
            Console.WriteLine("\nEncargos no asignados:");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (encargos[i, 4] == "0")
                {
                    Console.WriteLine($"| {i + 1} | {encargos[i, 1]} km | Sede {encargos[i, 2]} | Ganancia ${encargos[i, 3]} |");
                }
            }

            Console.Write("Seleccione el número del encargo a asignar: ");
            int indexAsignar = int.Parse(Console.ReadLine()) - 1;

            if (encargos[indexAsignar, 4] == "1")
            {
                Console.WriteLine("Ese encargo ya tiene camión asignado.");
            }
            else
            {
                Console.Write("Ingrese el código del camión: ");
                string codcamion = Console.ReadLine();
                encargos[indexAsignar, 0] = codcamion;
                encargos[indexAsignar, 4] = "1";
                Console.WriteLine("Camión asignado correctamente.");
            }
        }

        static void MostrarAsignados()
        {
            Console.WriteLine("\nEncargos asignados:");
            Console.WriteLine("\n| Fila | Codcamion | Distancia | Sede | Ganancia |");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (encargos[i, 4] == "1")
                {
                    Console.WriteLine($"| {i + 1} | {encargos[i, 0]} | {encargos[i, 1]} | {encargos[i, 2]} | {encargos[i, 3]} |");
                }
            }
        }

        static void PromedioGanancia()
        {
            double[] suma = new double[3];
            int[] cantidad = new int[3];
            string[] sedes = { "BSAS", "BB", "MDQ" };

            for (int i = 0; i < cantidad_registrados; i++)
            {
                int sedeIndex = int.Parse(encargos[i, 2]) - 1;
                suma[sedeIndex] += double.Parse(encargos[i, 3]);
                cantidad[sedeIndex]++;
            }

            for (int i = 0; i < 3; i++)
            {
                double promedio = (cantidad[i] > 0) ? suma[i] / cantidad[i] : 0;
                Console.WriteLine($"Promedio de ganancia en {sedes[i]}: ${promedio}");
            }
        }

        static void EncargoMayorDistancia()
        {
            int maxDist = 0;
            for (int i = 0; i < cantidad_registrados; i++)
            {
                int dist = int.Parse(encargos[i, 1]);
                if (dist > maxDist) maxDist = dist;
            }

            Console.WriteLine("\nEncargos con la mayor distancia:");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (int.Parse(encargos[i, 1]) == maxDist)
                {
                    Console.WriteLine($"{i + 1}. Distancia: {encargos[i, 1]} km, Ganancia: ${encargos[i, 3]}");
                }
            }
        }

        static void FiltrarPorCamion()
        {
            Console.Write("Ingrese el código del camión a buscar: ");
            string codigo = Console.ReadLine();

            Console.WriteLine($"Encargos del camión {codigo}:");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (encargos[i, 0] == codigo)
                {
                    Console.WriteLine($"| {i + 1} | Distancia: {encargos[i, 1]} km | Sede {encargos[i, 2]} | Ganancia ${encargos[i, 3]} |");
                }
            }
        }
    }
}

