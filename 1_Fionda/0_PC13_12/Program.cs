using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp12___Etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //profcortinez
            int ancho, alto;
            double perimetro, area, diagonal;

            Console.WriteLine("Escriba el ancho del rectangulo: ");
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el alto del rectangulo: ");
            alto = int.Parse(Console.ReadLine());

            perimetro = 2 * (ancho + alto);
            area = ancho * alto;
            diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(alto, 2));

            Console.WriteLine("El valor del perimetro es: " + perimetro);
            Console.WriteLine("El valor del area es: " + area);
            Console.WriteLine("El valor de la diagonal es: " + diagonal);

            Console.ReadKey();
        }
    }
}
