using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_0
{
    internal class Program
    {
        // Función que recibe un nombre y devuelve "Hola " + nombre
        static string Saludar(string nombre)
        {
            return "Hola " + nombre;
        }

        static void Main()
        {
            // Pedimos al usuario que ingrese su nombre
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();

            // Llamamos a la función Saludar
            string mensaje = Saludar(nombreUsuario);

            // Mostramos el resultado
            Console.WriteLine(mensaje);
        }
    }
} 
