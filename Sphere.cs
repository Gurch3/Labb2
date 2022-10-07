using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Sphere : Shape3D
    {
        public override string name => "Sphere";
        private Vector3 _center;
        private float _radius;
        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }

        public override float volume => ((4 * MathF.PI * MathF.Pow(_radius, 3)) / 3);

        public override Vector3 Center => _center;

        public override float Area => 4 * MathF.PI * MathF.Pow(_radius, 2);
        public override string ToString() => $"Sphere at({_center.X:f2},{_center.Y:f2},{_center.Z:f2}) with radius {_radius:f2}";

    }
}