using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Point3D
    {
        int x;
        int y;
        int z;


        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }
        public Point3D()
        {
            X = 0; Y = 0; Z = 0;
        }
        public Point3D(int _x, int _y, int _z)
        {
            X = _x; Y = _y; Z = _z;
        }

        public override string ToString() 
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }
    }
}
