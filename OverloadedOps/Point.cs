using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }
        public Point() { }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }

        #region Перегруженные операции + и -
        public static Point operator + (Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator - (Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
        #endregion

        #region Перегруженная операция + с числовым смещением
        public static Point operator + (Point p, int change)
        {
            return new Point(p.X + change, p.Y + change);
        }
        // При смене слагаемых
        public static Point operator + (int change, Point p)
        {
            return new Point(p.X + change, p.Y + change);
        }
        #endregion
    }
}
