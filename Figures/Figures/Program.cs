using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygons p;
            p = new Polygons(new Point[] { new Point(0, 0), new Point(1, 1) });

            Console.ReadKey();
        }
    }
}
