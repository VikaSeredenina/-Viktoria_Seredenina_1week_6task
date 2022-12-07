using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_6._1._2
{
    internal class Program
    {
            static int[,] Input(ref int min, ref int max)
            {
                Console.WriteLine("ДВУМЕРНЫЙ МАССИВ");
                Console.WriteLine("-----------------------------------------------");
                int n, m;
            while (true)
            {
                try
                {
                    Console.WriteLine("введите размерность массива (строки)");
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
            while (true)
            {
                try
                {
                    Console.WriteLine("введите размерность массива (столбцы)");
                    m = int.Parse(Console.ReadLine());
                    if (m == 0)
                    {
                        Console.WriteLine("Число должно быть больше 0");
                        continue;
                    }
                    else if (m < 0)
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

            int[,] a = new int[n, m];
           
                try
                {
                    for (int i = 0; i < n; ++i)
                        for (int j = 0; j < m; ++j)
                        {
                            Console.Write("a[{0},{1}]= ", i, j);
                            a[i, j] = int.Parse(Console.ReadLine());
                        }
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!!!");
                Environment.Exit(0);
                }
            

                Console.WriteLine("введите нижнюю границу диапазона");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("введите верхнюю границу диапазона");
                max = int.Parse(Console.ReadLine());
            if (min > max)
            {
                Console.WriteLine("Верхняя граница должна быть больше!");
                Environment.Exit(0);

            }
            return a;
        }

            static void Print(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                    for (int j = 0; j < a.GetLength(1); ++j)
                        Console.Write("{0,5} ", a[i, j]);
            }
            static int Sum(int[,] a, int min, int max)
            {
                int summa = 0;
                foreach (int elem in a)
                    if (elem > min && elem < max)
                        summa += elem;
                return summa;
            }

            static void Main(string[] args)
            {
                int min = 0, max = 0;
                int[,] myArray = Input(ref min, ref max);
                Console.WriteLine("Исходный массив:");
                Print(myArray);
                Console.WriteLine("Сумма: " + Sum(myArray, min, max));
            }
        }
    }



