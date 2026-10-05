using System;
using System.Collections.Generic;
using System.Text;

namespace CircleRectangle
{
    internal class Circle
    {
        private double r;
        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
                else
                    Console.WriteLine("Стойността на радиуса не може да бъде отрицателна или 0");
            }
        }

        public Circle()
        {
            r = 0;
        }

        public Circle(double r)
        {
            R = r;
        }

        public void AreaCircle()
        {
            Console.WriteLine($"Площта на кръга е: {Math.PI * r * r:F2}");
        }
    }
}
