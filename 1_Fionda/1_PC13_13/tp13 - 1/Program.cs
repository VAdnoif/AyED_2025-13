using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp13___1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salida = false;

            Console.WriteLine("Bienvenido al menu! ");

            while (!salida)
            {

                Console.WriteLine("1- Sumar dos valores ");
                Console.WriteLine("2- Restar dos valores ");
                Console.WriteLine("3- Contar hasta un valor ");
                Console.WriteLine("4- Salir ");

                string entrada = Console.ReadLine();

                Console.WriteLine();

                switch (entrada)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer valor: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        int n2 = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        int n3 = n1 + n2;

                        Console.WriteLine("La suma de esos dos valores es: " + n3);

                        Console.WriteLine();

                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer valor: ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor: ");
                        int r2 = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        int r3 = r1 - r2;

                        Console.WriteLine("La resta de esos dos valores es: " + r3);

                        Console.WriteLine();

                        break;
                    case "3":
                        Console.WriteLine("Ingrese el valor para contar: ");
                        int v1 = int.Parse(Console.ReadLine());

                        for(int i = 1; i<= v1; i++)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine();

                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa... ");

                        salida = true;

                        break;
                    default:
                        Console.WriteLine("Error numero fuera de rango, porfavor ingrese un numero entre el 1 al 4: ");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}
