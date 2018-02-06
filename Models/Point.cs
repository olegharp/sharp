using System;

namespace Sharp.Models
{
    class Point
    {
        int x;
        int y;
        static int objectCount = 0;
        public static int ObjectCount() => objectCount;
        public Point()
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
    }
}