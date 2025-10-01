using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");

            string[] mano = GenerarManoAleatoria();

            string tipo = TipoDeMano(mano);

            int basePts = PuntajeBase(mano);

            double mult = Multiplicador(tipo);

            double total = basePts * mult;

            bool jokerX2 = true;
            bool jokerMas10 = true;
            total = AplicarJokers(total, jokerX2, jokerMas10);

            MostrarResumen(mano, tipo, basePts, mult, total);
        }

        static string[] GenerarManoAleatoria()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };
            Random rnd = new Random();

            string[] mano = new string[5];
            for (int i = 0; i < 5; i++)
            {
                string rango = rangos[rnd.Next(rangos.Length)];
                string palo = palos[rnd.Next(palos.Length)];
                mano[i] = rango + palo;
            }
            return mano;
        }

        static string TipoDeMano(string[] mano)
        {
            char[] rangos = { 'A', 'K', 'Q', 'J', 'T', '9', '8', '7', '6', '5', '4', '3', '2' };
            int[] conteo = new int[rangos.Length]; 

            for (int i = 0; i < mano.Length; i++)
            {
                char rango = mano[i][0]; 
                for (int j = 0; j < rangos.Length; j++)
                {
                    if (rango == rangos[j])
                    {
                        conteo[j]++; 
                        break;
                    }
                }
            }

            bool hayPar = false;
            bool hayTrio = false;

            
            for (int i = 0; i < conteo.Length; i++)
            {
                if (conteo[i] == 4)
                {
                    return "Poker";
                }
                    
                else if (conteo[i] == 3)
                {
                    hayTrio = true;
                }
                else if (conteo[i] == 2)
                {
                    hayPar = true;
                }
            }

            if (hayTrio && hayPar)
            {
                return "Full";
            }
            else if (hayTrio)
            {
                return "Trio";
            }
            else if (hayPar)
            {
                return "Par";
            }
            else
            {
                return "Par";
            }
        }

        static int PuntajeBase(string[] mano)
        {
            int ValorCarta(char rango)
            {
                switch (rango)
                {
                    case 'A': return 14;
                    case 'K': return 13;
                    case 'Q': return 12;
                    case 'J': return 11;
                    case 'T': return 10;
                    default: return int.Parse(rango.ToString());
                }
            }

            int suma = 0;
            foreach (string carta in mano)
            {
                suma += ValorCarta(carta[0]);
            }
            return suma;
        }

        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Par": return 1.5;
                case "Trio": return 2.5;
                case "Full": return 3.5;
                case "Poker": return 4.0;
                default: return 1.0;
            }
        }

        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            if (x2) puntaje *= 2;
            if (mas10) puntaje += 10;
            return puntaje;
        }

        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.WriteLine("Mano: " + string.Join(" ", mano.Select(c => $"[{c}]")));
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Puntaje base: " + basePts);
            Console.WriteLine("Multiplicador: x" + mult);
            Console.WriteLine("Total (con Jokers): " + total);
        }
    }
}
