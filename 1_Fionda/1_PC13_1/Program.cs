using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseñaGuardada = "MiContraseña123";

            Console.Write("Ingrese la contraseña: ");
            string contraseñaIngresada = Console.ReadLine();


            if (contraseñaGuardada == contraseñaIngresada)
            {
                Console.WriteLine("Contraseña correcta");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }
        }
    }
}
