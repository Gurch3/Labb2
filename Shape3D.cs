using System;


namespace ClassLibrary1
{

    public abstract class Shape3D : Shape
    {
        public abstract string name { get; }
        public abstract float volume { get; }
    }
}