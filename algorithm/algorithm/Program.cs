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
            //Задание №3, вычисление числа фибоначи в рекурсии и без неё.
            Console.Write("Введи число фибоначи: ");
            string L = Console.ReadLine();
            int l = Convert.ToInt32(L);
            Console.Clear();

            if (l < 1)
            {
                Console.WriteLine("Введённые данные не число, равны 0 или меньше 0.");
                throw new ArgumentException("L должно быть положительным числом больше нуля.");
            }


            for (int n = 1; n <= l; n++)
            {
                Console.WriteLine($"Число Фибоначи({n}) = {Fib.NumFibonachi(n)} Колличество итераций = {Fib.Fibonachi}");
                Fib.Fibonachi = 0;
            }
            Console.WriteLine();

            for (int n = 1; n <= l; n++)
            {
                Console.WriteLine($"Число Фибоначи({n}) = {Fib.NumRecFibonachi(n)} Колличество итераций = {Fib.FibonachiRec}");
                Fib.FibonachiRec = 0;
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            
            

            //Задание №2, просчитать сложность функции (тело в SS).
            // O(3 + (N * N * 3N)  ; вроде так =-=
            // Упрощённый вариант с пренебрежением О(3) по третьему правилу, и O(3N) по пятому правилу:
            // O(N^3) -, т.е. 3 в кубе. Но его мы использовать не будем, оставив максимально точный вариант. 
            // Я только так и не понял, как на основе этих цифр можно судить о эффективности програмного кода. 
            // Просто сравнение получаемого значения с анлогами и другими исполнениями того же алгоритма?

            //Console.Write("Введи число: ");
            //string h = Console.ReadLine();
            //int H = Convert.ToInt32(h);
            //Console.Clear();

            //SS.inputArray = H;
            //long O = 0;
            //int N = SS.inputArray;
            //O = 3 + (N * N * (3 * N));
            //Console.WriteLine($"Асимптотическая сложность функции: " + O);
            //Console.ReadKey();
            //Console.Clear();


            //Задание №1, построить алгоритм по блоксхеме.

            //Console.Write("Введи число, проверим, простое оно или нет: ");
            //string М = Console.ReadLine();
            //int m = Convert.ToInt32(М);
            //Console.Clear();

            //int d = 0;
            //int i = 2;

            //while (i < m)
            //{
            //    if (m % i == 0)
            //    {
            //         d++;
            //         i++;
            //    }
            //    else i++;
            //}

            //if (d == 0)
            //{
            //    Console.WriteLine("Число простое.");
            //}
            //else
            //{
            //    Console.WriteLine("Число совсем не простое!");
            //}



        }
    }
}
