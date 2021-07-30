using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    class Fib
    {
        public static decimal Fibonachi = 0;
        public static decimal FibonachiRec = 0;

        public static decimal NumFibonachi(int F)
        {
            Fibonachi++;
            decimal start = 1;
            decimal fNum1 = 1;
            decimal fNum2 = 1;
            for (int i = 2; i <= F; i++)
            {
                start = fNum1 + fNum2;

                fNum1 = fNum2;
                fNum2 = start;
                Fibonachi++;
            }
            return start;

            
        }

        public static decimal NumRecFibonachi(int F, decimal fNum1 = 1, decimal fNum2 = 1)
        {
            FibonachiRec++;
            if (F > 1) return NumRecFibonachi(F - 1, fNum2, fNum1 + fNum2);
            else return fNum2;
        }

    }
}
