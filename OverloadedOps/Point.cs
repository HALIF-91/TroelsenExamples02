using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Point : IComparable<Point>
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

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            else if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
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

        #region Перегрузка унарных операций
        public static Point operator ++ (Point p)
        {
            return new Point(p.X + 1, p.Y + 1);
        }
        public static Point operator -- (Point p)
        {
            return new Point(p.X - 1, p.Y - 1);
        }
        #endregion

        #region Перегрузка операций == и !=
        public static bool operator == (Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator != (Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        #endregion

        #region Перегрузка операций сравнения
        public static bool operator > (Point p1, Point p2)
        {
            return (p1.CompareTo(p2) > 0);
        }
        public static bool operator < (Point p1, Point p2)
        {
            return (p1.CompareTo(p2) < 0);
        }
        public static bool operator >= (Point p1, Point p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }
        public static bool operator <= (Point p1, Point p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }
        #endregion
    }
}
