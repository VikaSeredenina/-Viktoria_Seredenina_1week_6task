using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_6._3
{
    internal class Program
    {
        static int[,] Input(out int n)
        {
        
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
            int[,] a = new int[n, n];
             try
                {
                    for (int i = 0; i < n; ++i)
                        for (int j = 0; j < n; ++j)
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
                return a;
            
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }

        static int[,] Rezalt(int[,] a)
        {

            if (a.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < a.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        int temp = a[i + 1, j];
                        a[i + 1, j] = a[i, j];
                        a[i, j] = temp;
                    }
                    i++;
                }
                return a;
            }
            else return a;
        }

        static void Main(string[] args)
        {
            int n;
            int[,] myArray = Input(out n);
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            int[,] res = new int[n, n];
            Console.WriteLine("Полученный массив:");
            res = Rezalt(myArray);
            Print(res);
        }
    }
}
