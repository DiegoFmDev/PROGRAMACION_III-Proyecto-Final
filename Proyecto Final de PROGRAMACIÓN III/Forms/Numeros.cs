using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    internal class Numeros
    {
        public static int Mayor(int number)
        {
            return number.ToString().Select(digit => int.Parse(digit.ToString())).Max();
        }

        public static int SumaPares(int number)
        {
            return number.ToString().Where(digit => int.Parse(digit.ToString()) % 2 == 0).Sum(digit => int.Parse(digit.ToString()));
        }

        public static int MoverMayor(int number)
        {
            var digits = number.ToString().Select(digit => int.Parse(digit.ToString())).ToList();
            int maxDigit = digits.Max();
            digits.Remove(maxDigit);
            digits.Add(maxDigit);
            return int.Parse(string.Join("", digits));
        }

        public static bool EstaOrdenado(int number)
        {
            var digits = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] > digits[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int CantDigPares(int number)
        {
            var digits = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int count = 0;
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 0 && digits[i - 1] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

