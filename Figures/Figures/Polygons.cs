using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Polygons: Figure
    {
        Point[] vertices;
        public Polygons() { }

        public Polygons(Point[] Points)
        {
            if (Points.Length < 3)
            {
                throw new Exception("Должно быть 3 точки");
            }
        }
    }
}
