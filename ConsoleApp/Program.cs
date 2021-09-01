using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masInt = { 1, 2, 3, 4, 5 };
            double[] masDoub = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] masStr = { "one", "two", "three", "four", "five" };
            decimal[] masDec = { 11, 22, 33, 44, 55 };
            Console.WriteLine();

            ArrayHelper.Pop(ref masInt);
            Console.WriteLine();

            ArrayHelper.Push(ref masDoub, 6.6);

            ArrayHelper.Shift(ref masDec);
            Console.WriteLine();

            ArrayHelper.UnShift(ref masStr, "newEl");
        }
    }

    static class ArrayHelper
    {

        public static int Pop (ref int [] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РОР");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удлённый элемент массива: {array[array.Length - 1]}");
            return array[array.Length - 1];
        }
        public static void Push(ref int[] array, int el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РUSH");
            
            int[] array2 = new int[array.Length + 1];
            array2[array2.Length - 1] = el;
            for (int i = 0; i < array2.Length; i++)
            {
                if (i < array.Length)
                {
                    array2[i] = array[i];
                }
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }
        public static int Shift(ref int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод SHIFT");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                if (i == 0) continue;
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удалёный элемент массива: {array[0]} ");
            return array[0];
        }
        public static void UnShift (ref int [] array, int el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод UNSHIFT");
            int[] array2 = new int[array.Length + 1];
            array2[0] = el;
            for (int i = 1; i < array2.Length; i++)
            {
                array2[i] = array[i - 1];
                if (i == 1) Console.Write($"Элементы нового массива: {array2[0]}, ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }


        public static double Pop(ref double[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РОР");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удлённый элемент массива: {array[array.Length - 1]}");
            return array[array.Length - 1];
        }
        public static void Push(ref double[] array, double el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РUSH");

            double[] array2 = new double[array.Length + 1];
            array2[array2.Length - 1] = el;
            for (int i = 0; i < array2.Length; i++)
            {
                if (i < array.Length)
                {
                    array2[i] = array[i];
                }
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }
        public static double Shift(ref double[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод SHIFT");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                if (i == 0) continue;
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удалёный элемент массива: {array[0]} ");
            return array[0];
        }
        public static void UnShift(ref double[] array, double el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод UNSHIFT");
            double[] array2 = new double[array.Length + 1];
            array2[0] = el;
            for (int i = 1; i < array2.Length; i++)
            {
                array2[i] = array[i - 1];
                if (i == 1) Console.Write($"Элементы нового массива: {array2[0]}, ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }


        public static string Pop(ref string[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РОР");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удлённый элемент массива: {array[array.Length - 1]}");
            return array[array.Length - 1];
        }
        public static void Push(ref string[] array, string el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РUSH");

            string[] array2 = new string[array.Length + 1];
            array2[array2.Length - 1] = el;
            for (int i = 0; i < array2.Length; i++)
            {
                if (i < array.Length)
                {
                    array2[i] = array[i];
                }
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }
        public static string Shift(ref string[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод SHIFT");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                if (i == 0) continue;
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удалёный элемент массива: {array[0]} ");
            return array[0];
        }
        public static void UnShift(ref string[] array, string el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод UNSHIFT");
            string[] array2 = new string[array.Length + 1];
            array2[0] = el;
            for (int i = 1; i < array2.Length; i++)
            {
                array2[i] = array[i - 1];
                if (i == 1) Console.Write($"Элементы нового массива: {array2[0]}, ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }

        public static decimal Pop(ref decimal[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РОР");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удлённый элемент массива: {array[array.Length - 1]}");
            return array[array.Length - 1];
        }
        public static void Push(ref decimal[] array, decimal el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РUSH");

            decimal[] array2 = new decimal  [array.Length + 1];
            array2[array2.Length - 1] = el;
            for (int i = 0; i < array2.Length; i++)
            {
                if (i < array.Length)
                {
                    array2[i] = array[i];
                }
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }
        public static decimal Shift(ref decimal[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод SHIFT");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                if (i == 0) continue;
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удалёный элемент массива: {array[0]} ");
            return array[0];
        }
        public static void UnShift(ref decimal[] array, decimal el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод UNSHIFT");
            decimal[] array2 = new decimal[array.Length + 1];
            array2[0] = el;
            for (int i = 1; i < array2.Length; i++)
            {
                array2[i] = array[i - 1];
                if (i == 1) Console.Write($"Элементы нового массива: {array2[0]}, ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }

        public static float Pop(ref float[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РОР");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удлённый элемент массива: {array[array.Length - 1]}");
            return array[array.Length - 1];
        }
        public static void Push(ref float[] array, float el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод РUSH");

            float[] array2 = new float[array.Length + 1];
            array2[array2.Length - 1] = el;
            for (int i = 0; i < array2.Length; i++)
            {
                if (i < array.Length)
                {
                    array2[i] = array[i];
                }
                if (i == 0) Console.Write($"Элементы нового массива: ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }
        public static float Shift(ref float[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Метод SHIFT");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0) Console.Write($"Элементы нового массива: ");
                if (i == 0) continue;
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Удалёный элемент массива: {array[0]} ");
            return array[0];
        }
        public static void UnShift(ref float[] array, float el)
        {
            Console.WriteLine();
            Console.WriteLine("Метод UNSHIFT");
            float[] array2 = new float[array.Length + 1];
            array2[0] = el;
            for (int i = 1; i < array2.Length; i++)
            {
                array2[i] = array[i - 1];
                if (i == 1) Console.Write($"Элементы нового массива: {array2[0]}, ");
                Console.Write($"{array2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Обновленная длина массива: {array2.Length}");
        }
    }
}
