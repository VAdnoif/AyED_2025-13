using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
            int[,] g =
            {
            {0,1,0},
            {1,0,1},
            {0,1,0}
            };
            bool ok = Level3.CountAdjacent(g, 1, 1) == 4
                   && Level3.CountAdjacent(g, 0, 0) == 2;
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
        }
    }

    static class Level3
    {
        public static int CountAdjacent(int[,] grid, int row, int col)
        {
            // TODO: implementar
            // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
            // Devolver cuántos valen 1
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            int count = 0;

            // arriba
            if (row - 1 >= 0 && grid[row - 1, col] == 1)
                count++;

            // abajo
            if (row + 1 < rows && grid[row + 1, col] == 1)
                count++;

            // izquierda
            if (col - 1 >= 0 && grid[row, col - 1] == 1)
                count++;

            // derecha
            if (col + 1 < cols && grid[row, col + 1] == 1)
                count++;

            return count;
        }
    }
}
