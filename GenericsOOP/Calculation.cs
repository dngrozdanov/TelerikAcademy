using System;
namespace GenericsOOP
{
    public static class Calculation
    {
        public static float Distance3D(Point first, Point second)
        {
            float distance = 0;
            float deltaX = second.X - first.X;
            float deltaY = second.Y - first.Y;
            float deltaZ = second.Z - first.Z;
            distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
}