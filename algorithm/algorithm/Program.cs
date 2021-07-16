using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm
{
    class Program
    {


        public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            float M = (x * x) + (y * y);
            return M;
           
        }

        public struct PointStruct
        {
            public float X;
            public float Y;
        }

        static void Main(string[] args)
        {
            var pointOne = new PointStruct { X = 10, Y = 20 };
            //pointOne.X = 10;
            //pointOne.Y = 20;
            var pointTwo = new PointStruct { X = 20, Y = 30 };
            //pointTwo.X = 40;
            //pointTwo.Y = 80;
            Console.WriteLine(PointDistance);


        }

       
    }
}
