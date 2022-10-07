using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Rectangle : Shape2D
    {
        public string name;
        private Vector2 _size;
        private Vector3 _center;
        public bool IsSquare { get { return _size.Y == _size.X; } }

        public Rectangle(Vector2 center, float width)
        {
            _size = new Vector2(width);
            _center = new Vector3(center, 0f);
        }

        public Rectangle(Vector2 center, Vector2 size)
        {
            _size = size;
            _center = new Vector3(center, 0f);
            
        }

        public override Vector3 Center { get { return _center; } }

        public override float circumference { get { return (_size.X + _size.Y) * 2; } }
        public override float Area { get { return _size.X * _size.Y;} }

        public override string ToString()
        {
            if(IsSquare)
            {
                name = "Square";
                return $"Square at({_center.X:f2},{_center.Y:f2}) with height and width {_size.X:f2}";
            }
            else
            {
                name = "Rectangle";
                return $"Rectangle at({_center.X:f2},{_center.Y:f2}) with height {_size.Y:f2} and width {_size.X:f2}";
            }
        }
    }
}
