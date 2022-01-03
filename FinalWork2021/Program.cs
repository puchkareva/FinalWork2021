using System;

namespace FinalWork2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.


               int[] GetArray(int length, int minValue, int maxValue)
            {
                int[] array = new int[length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = new Random().Next(minValue, maxValue + 1);
                }
                return array;
            }

            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.Write($"{arr[i]} ");
                }
            }


            int[] SeparateEvenElements(int[] a)
            {
                int[] b = new int[a.Length];
                int j = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        b[j] = a[i];
                        j++;
                    }
                }
                Array.Resize(ref b, j);
                return b;
            }

            int[] arrayA = GetArray(10, -20, 20);
            int[] arrayB = SeparateEvenElements(arrayA);
            PrintArray(arrayA);
            Console.WriteLine();
            PrintArray(arrayB);


        }
    }
}
