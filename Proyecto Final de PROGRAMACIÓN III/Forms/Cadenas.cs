using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    internal class Cadenas
    {
        public static int CantPal(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string EliminarVoc(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return new string(input.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
        }

        public static string CadenaMasLarga(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderByDescending(word => word.Length)
                .FirstOrDefault() ?? string.Empty;
        }

        public static string EliminaPrim(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return string.Join(" ", input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.Length > 1 ? word.Substring(1) : string.Empty));
        }

        public static string InvertirPal(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return string.Join(" ", input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => new string(word.Reverse().ToArray())));
        }
    }
}