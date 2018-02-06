using System;

namespace Sharp.Models
{
    class Circle
    {
        int radius;
        public static int NumCircles = 0;
        public Circle()
        {
            radius = 0;
            NumCircles++;
        }
        public Circle(int initialRadius)
        {
            radius = initialRadius;
            NumCircles++;
        }
    }
}