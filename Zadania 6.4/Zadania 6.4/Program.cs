using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_6._4
{
    internal class Program
    {
        static int[][] Input()
        {
            int n;
            while (true)
            {
                try
                {
                    Console.WriteLine("введите размерность массива");
                    n = int.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        Console.WriteLine("Число должно быть больше 0");
                        continue;
                    }
                    else if (n < 0)
                    {
                        Console.WriteLine("Число должно быть положительным");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!!!");
                }
            }
            int[][] a = new int[n][];
            try
            {
                for (int i = 0; i < n; ++i)
                {
                    a[i] = new int[n];
                    for (int j = 0; j < n; ++j)
                    {
                        Console.Write("a[{0},{1}]= ", i, j);
                        a[i][j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод!!!");
                Environment.Exit(0);
            }
            return a;
        }

        static void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0,5} ", a[i]);
        }

        static void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }

        static int[] F(int num, int[][] array)
        {
            int[] res = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int counting = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] >= num)
                    {
                        counting++;

                    }
                    res[i] = counting;
                }

            }
            return res;
        }

        static void Main(string[] args)
        {
            int[][] myArray = Input();
            Console.WriteLine("Исходный массив:");
            Print2(myArray);
            int[] rez = new int[myArray.Length];
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            rez = F(num, myArray);
            Console.WriteLine("Новый массив:");
            Print1(rez);
        }
    }
}
