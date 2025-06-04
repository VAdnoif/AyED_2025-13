using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp11___Etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius, kelvin, farenheit;

            Console.WriteLine("Escriba la temperatura en grados celcius: ");
            celcius = int.Parse(Console.ReadLine());

            farenheit = (celcius * 9 / 5) + 32;
            kelvin = (celcius + 273.15);

            Console.WriteLine("La temperatura en farenheit es: " + farenheit);
            Console.WriteLine("La temperatura en kelvin es: " + kelvin);

            Console.ReadKey();
        }
    }
}
