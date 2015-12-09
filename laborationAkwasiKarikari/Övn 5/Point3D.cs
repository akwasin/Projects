using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övn_5
{
    class Point3D : Point
    {
        private int _z;

        public void SetZ(int z) { this._z = _z; }
        public int GetZ() { return _z; }

        public Point3D()
        {
            // default konstruktor
        }

        public Point3D(int x, int y, int z) : base (x, y)
        {
            this._z = _z;
        }
    }

}
