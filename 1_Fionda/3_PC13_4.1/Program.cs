﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_4._1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
            bool ok = Level1.ValidateAccessKey("WD-700000")
                      && !Level1.ValidateAccessKey("WD-123123")
                      && !Level1.ValidateAccessKey("WX-000007")
                      && !Level1.ValidateAccessKey("WD-00007");
            if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
            else Console.WriteLine("🔒 LOCKED");
        }
    }

    static class Level1
    {
        // Debe devolver true solo si:
        // - Empieza por "WD-"
        // - Luego hay exactamente 6 dígitos
        // - La suma de esos 6 dígitos es múltiplo de 7
        public static bool ValidateAccessKey(string key)
        {
            // TODO: implementar
            if (string.IsNullOrEmpty(key)) return false;

            const string prefijo = "WD-";
            if (!key.StartsWith(prefijo)) return false;

            
            if (key.Length != prefijo.Length + 6) return false;

            int sum = 0;
            for (int i = prefijo.Length; i < key.Length; i++)
            {
                char c = key[i];
                if (!char.IsDigit(c)) return false;
                sum += c - '0';
            }

            return sum % 7 == 0;

        }
    }
}
