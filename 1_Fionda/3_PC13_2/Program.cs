using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_2
{
    internal class Program
    {
        static int Sumar(int a, int b) 
        { 
            return a + b;
        }
            
        static int Restar(int a, int b)
        {
            return a - b;
        }
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        static double Dividir(int a, int b)
        {
            if (b == 0)
        {
            Console.WriteLine("Error, No se puede dividir por cero");
            return 0;
        }
        return (double)a / b;
        }
        static void Calculadora()
        {
            
            Console.Write("Ingrese el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione operación:");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.Write("Opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Resultado: " + Sumar(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + Restar(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Resultado: " + Dividir(num1, num2));
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
            
        static void Main(string[] args)
        {
            Calculadora();
        }
    }
}


