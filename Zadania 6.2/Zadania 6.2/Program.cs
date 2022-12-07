using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_6._2
{
    internal class Program
    {
        static double[] Input()
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
            double[] a = new double[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = double.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Main(string[] args)
        {
            double[] myArray = Input();
            double sum = 0;

            var min = Array.IndexOf(myArray, myArray.Min()); //нахождение минимального элемента
            var max = Array.IndexOf(myArray, myArray.Max()); //нахождение максимального элемента

            if (min > max)
            {
                for (int i = max + 1; i < min; i++)
                    sum += myArray[i];
                Console.WriteLine("Сумма элементов = " + sum);
            }
            else
                Console.WriteLine("Максимальный элемент встречается позже минимального");
        }
    }
}

