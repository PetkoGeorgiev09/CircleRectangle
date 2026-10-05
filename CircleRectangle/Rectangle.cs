using System;
using System.Collections.Generic;
using System.Text;

namespace CircleRectangle
{
    internal class Rectangle
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                    Console.WriteLine("Стойността на страната не може да бъде отрицателна или 0");
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                    Console.WriteLine("Стойността на страната не може да бъде отрицателна или 0");
            }
        }

        public Rectangle()
        {
            A = 0;
            B = 0;
        }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public void AreaRectangle()
        {
            Console.WriteLine($"Площа на правоъгълника е: {A * B:F2}");
        }
    }
}
