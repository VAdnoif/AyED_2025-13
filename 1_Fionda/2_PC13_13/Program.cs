using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC13_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int n = int.Parse(Console.ReadLine());

            string[,] estudiantes = new string[n, 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEstudiante #{0}",(i+1));

                Console.Write("Nombre: ");
                estudiantes[i, 0] = Console.ReadLine();

                Console.Write("Edad: ");
                estudiantes[i, 1] = Console.ReadLine();

                Console.Write("Calificación: ");
                estudiantes[i, 2] = Console.ReadLine();
            }

            Console.WriteLine("\nListado de estudiantes:");
            Console.WriteLine("Nombre\t\tEdad\tCalificación");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}", estudiantes[i, 0], estudiantes[i, 1], estudiantes[i, 2]);
            }
            Console.ReadKey();
        }
    }
}
