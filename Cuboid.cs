using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Cuboid : Shape3D
    {
        public override string name => IsCube ? "Cube" : "Cuboid";
        private Vector3 _center;
        private Vector3 _size;

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }
        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _size = new Vector3(width);
        }

        public bool IsCube => _size.X == _size.Y && _size.X == _size.Z;
        public override float volume => _size.X * _size.Y * _size.Z;

        public override Vector3 Center =>_center;

        public override float Area => 2 * _size.X * _size.Y + 2 * _size.X * _size.Z;

        public override string ToString()
        {
            if(IsCube)
            {
                return $"Cube at({_center.X:f2},{_center.Y:f2},{_center.Z:f2}) with width height and depth {_size.X:f2}";
            }
            else
            {
                return $"Cuboid at({_center.X:f2},{_center.Y:f2},{_center.Z:f2}) with width {_size.X:f2}, height {_size.Y:f2} and depth {_size.Z:f2}";
            }
        }
    }
}
