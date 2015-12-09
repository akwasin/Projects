using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övn_5
{

    public class Circle
    {
        private double _diameter;
        private Point _center;

        public void SetDiameter(double diameter) { if (diameter > 0) { this._diameter = diameter; } }

        public double GetDiameter() { return _diameter; }

        public double GetCircumference() { return Math.PI * _diameter; }

        public void SetCenter(Point p)
        {
            if (p != null)
            {
                _center = p;
            }
            else
            {
                Point tempP = new Point();
                tempP.SetX(10); // default värde
                tempP.SetY(10); // default värde
                _center = tempP;
            }
        }
        public override string ToString()
        {
            return _diameter.ToString();
        }
        public Point GetCenter() { return _center; }
    }
    
    public class Point
    {
        private int _y;
        private int _x;

        public void SetX(int x) { this._x = x; }
        public int GetX() { return _x; }

        public void SetY(int y) { this._y = y; }

        public int GetY() { return _y; }

        public Point()
        {
        // default konstruktor
        }

        public Point(int x, int y)
        {
            this._x = _x;
            this._y = _y;
        }

    }
}
