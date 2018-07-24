using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct Triangle
    {
    //    Triangle tr1 = new Triangle(new Point(0, 9), new Point(0, 5), new Point(9, 0), Layout.Symple);
    //    Triangle tr2 = new Triangle(new Point(0, 9), new Point(0, 5), new Point(9, 0), Layout.Inverted);

    //    Triangle[] triangles = new Triangle[2];

    //    triangles[0] = tr1;
    //        triangles[1] = tr2;



        private Point[] _points;
        public Triangle(Point p1, Point p2, Point p3)
        {
            _points = new Point[3];

            _points[0] = p1;
            _points[1] = p2;
            _points[2] = p3;

        }

        public void ShowCordinates()
        {
            int y = 0;
            for (int i = 0; i < _points.Length; i++)
            {   
                Console.WriteLine($"[{i} Point : x:{_points[i].X}, y {_points[y].Y}");
            }
            
        }
       
    }
}
