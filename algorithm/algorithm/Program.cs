using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace algorithm
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            ////Задание №3, вычисление числа фибоначи в рекурсии и без неё.
            //Console.Write("Введи число фибоначи: ");
            //string L = Console.ReadLine();
            //int l = Convert.ToInt32(L);
            //Console.Clear();



            //for (int n = 1; n <= l; n++)
            //{
            //    Console.WriteLine($"Число Фибоначи({n}) = {Fib.NumFibonachi(n)} Колличество итераций = {Fib.Fibonachi}");
            //    Fib.Fibonachi = 0;
            //}
            //Console.WriteLine();

            //for (int n = 1; n <= l; n++)
            //{
            //    Console.WriteLine($"Число Фибоначи({n}) = {Fib.NumRecFibonachi(n)} Колличество итераций = {Fib.FibonachiRec}");
            //    Fib.FibonachiRec = 0;
            //}
            //Console.WriteLine();
            //Console.ReadKey();
            //Console.Clear();

            ////Задание №2, просчитать сложность функции.
            //// O(2+(N*N*4N) =-=
            //// упрощённый вариант с пренебрежением О(2) и O(4N)
            //// O(N*N*N) - но его мы использовать не будем. 
            //// я только так и не понял, как на основе этих цифр можно судить о эффективности програмного кода. Сравнение с анлогами?

            //Console.Write("Введи число: ");
            //string h = Console.ReadLine();
            //int H = Convert.ToInt32(h);
            //Console.Clear();


            //SS.inputArray = H;
            //long O = 0;
            //int N = SS.inputArray;
            //O = 2 + (N * N * (4 * N));
            //Console.WriteLine($"Асимптотическая сложность функции: " + O);
            //Console.ReadKey();
            //Console.Clear();


            //Задание №1, построить алгоритм по блоксхеме.

            Console.Write("Введи число, проверим, простое оно или нет: ");
            string М = Console.ReadLine();
            int m = Convert.ToInt32(М);
            Console.Clear();

            int d = 0;
            int i = 2;

            while (i < m)
            {
                if (m % i == 0)
                {
                     d++;
                     i++;
                }
                else i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Число простое.");
            }
            else
            {
                Console.WriteLine("Число совсем не простое!");
            }
         
            

        }
    }
}
