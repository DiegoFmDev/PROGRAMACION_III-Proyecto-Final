using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_PROGRAMACIÓN_III.Forms
{
    internal class Vectores
    {
        public static int CountEvens(int[] vector)
        {
            return vector.Count(n => n % 2 == 0);
        }

        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            int[] leftArray = array[left..(middle + 1)];
            int[] rightArray = array[(middle + 1)..(right + 1)];

            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                }
            }

            while (i < leftArray.Length)
            {
                array[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                array[k++] = rightArray[j++];
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        public static int[] RemoveElement(int[] array, int x)
        {
            return array.Where(val => val != x).ToArray();
        }

        public static void InvertSection(int[] array, int a, int b)
        {
            Array.Reverse(array, a, b - a + 1);
        }
    }
}
