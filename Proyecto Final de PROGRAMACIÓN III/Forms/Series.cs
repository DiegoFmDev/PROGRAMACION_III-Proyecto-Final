using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    internal class Series
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static int Serie1(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 3;

            int vi = 2;
            int c = 0;
            int SW = 1;

            for (int i = 3; i <= n; i++)
            {
                if (SW == 1)
                {
                    vi = vi + 1;
                    SW = 0;
                }
                else
                {
                    vi = vi * 2;
                    SW = 1;
                    c = c + 1;
                }
            }
            return vi;
        }

        public static int SumaSerie(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += 2 * i;
            }
            return sum;
        }

        public static int Serie2(int n)
        {
            if (n == 1) return 1;
            return Serie2(n - 1) * 2 + 1;
        }

        public static int SumaSerie2(int n)
        {
            int[] serie = { 1, 2, 4, 5, 10, 12, 13, 26, 28, 29 };
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (serie[i] % 2 == 0)
                    sum += serie[i];
            }
            return sum;
        }
    }
}