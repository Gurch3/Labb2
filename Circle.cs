using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    public class Circle : Shape2D
    {
        public string name = "Circle";
        private float _radius;

        private Vector3 _center;

        public Circle (Vector2 center, float Radius)
        {
                
            _center = new Vector3(center, 0f);
            _radius = Radius;
    }

        public override float circumference => _radius * 2 * MathF.PI;

        public override Vector3 Center => _center;

        public override float Area => MathF.Pow(_radius, 2) * MathF.PI;

        public override string ToString() => $"Circle at({_center.X:f2}, {_center.Y:f2}) with radius = {_radius:f2}";
       
    }
}
