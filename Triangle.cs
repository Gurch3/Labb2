using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : Shape2D
    {
        public string name = "Triangle";
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private float side1 => Vector2.Distance(p1, p2);
        private float side2 => Vector2.Distance(p1, p3);
        private float side3 => Vector2.Distance(p2, p3);

        private Vector3 _center;
        public Triangle(Vector2 P1, Vector2 P2, Vector2 P3)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
            _center = new Vector3((P1.X + P2.X + P3.X) / 3, (P1.Y + P2.Y + P3.Y) / 3, 0f); 
        }

        public Triangle(Vector2 P1, Vector2 P2, Vector3 Center) : this(P1, P2, Vector2.Zero)
        { 
            _center = Center;
            p3 = new Vector2(Center.X * 3 - P1.X - P2.X, Center.Y * 3 - P1.Y - P2.Y);
        }

      
      
        public override float circumference => side1 + side2 + side3;

        public override Vector3 Center => _center;

        public override float Area => MathF.Sqrt(((side1 + side2 + side3) / 2) * ((side1 + side2 + side3) / 2 - side1) * ((side1 + side2 + side3) / 2 - side2) * ((side1 + side2 + side3) / 2 - side3));

        public override string ToString() => $"Triangle at({_center.X:f2},{_center.Y:f2}) with corners at P1(X:{p1.X:f2} Y:{p1.Y:f2}) P2(X:{p2.X:f2} Y:{p2.Y:f2})";



    }
}
