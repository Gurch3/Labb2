using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    public abstract class Shape
    {
        public static int[] shapeCounter = new int[7];
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Shapes currentShape = (Shapes)new Random().Next(0, 7);

            float centerX = (float)Random.Shared.NextDouble() * new Random().Next(-100, 100);
            float centerY = (float)Random.Shared.NextDouble() * new Random().Next(-100, 100);
            float centerZ = (float)Random.Shared.NextDouble() * new Random().Next(-100, 100);

            float width = (float)Random.Shared.NextDouble() * Random.Shared.Next(0, 100);
            float height = (float)Random.Shared.NextDouble() * Random.Shared.Next(0, 100);
            float depth = (float)Random.Shared.NextDouble() * Random.Shared.Next(0, 100);


            switch (currentShape)
            {
                case Shapes.Circle:
                  
                    Circle newCircle = new(new Vector2(centerX, centerY), width);
                    shapeCounter[0]++;
                    return newCircle;
                    
         
                case Shapes.Rectangle:

                    Rectangle newRectangle = new(new Vector2(centerX, centerY), new Vector2(width, height));
                    shapeCounter[1]++;
                    return newRectangle;

                    
                case Shapes.Square:

                    Rectangle newSquare = new(new Vector2(centerX, centerY), width);
                    shapeCounter[2]++;
                    return newSquare;

                case Shapes.Sphere:

                    Sphere newSphere = new(new Vector3(centerX, centerY, centerZ), width);
                    shapeCounter[3]++;
                    return newSphere;

                    
                case Shapes.Cuboid:

                    Cuboid newCuboid = new(new Vector3(centerX, centerY, centerZ), new Vector3(width, height, depth));
                    shapeCounter[4]++;
                    return newCuboid;

                case Shapes.Cube:

                    Cuboid newCube = new(new Vector3(centerX, centerY, centerZ), width);
                    shapeCounter[5]++;
                    return newCube;
                case Shapes.Triangle:

                    Vector2 P1 = Shape.GetTrianglePoint();
                    Vector2 P2 = Shape.GetTrianglePoint();
                    Vector2 P3 = Shape.GetTrianglePoint();
                    Triangle newTriangle = new(P1, P2, P3);
                    shapeCounter[6]++;
                    return newTriangle;
                    






                default: throw new ArgumentOutOfRangeException();


            }
          
        }
        public static Shape GenerateShape(Vector3 Center)
        {
            Shapes currentShape = (Shapes)new Random().Next(0, 7);

            float width = (float)Random.Shared.NextDouble() * Random.Shared.Next(0, 100);
            float height = (float)Random.Shared.NextDouble() * Random.Shared.Next(0, 100);
            float depth = (float)Random.Shared.NextDouble() * Random.Shared.Next(0, 100);


            switch (currentShape)
            {
                case Shapes.Circle:

                    Circle newCircle = new(new Vector2(Center.X, Center.Y), width);
                    shapeCounter[0]++;
                    return newCircle;


                case Shapes.Rectangle:

                    Rectangle newRectangle = new(new Vector2(Center.X, Center.Y), new Vector2(width, height));
                    shapeCounter[1]++;
                    return newRectangle;


                case Shapes.Square:

                    Rectangle newSquare = new(new Vector2(Center.X, Center.Y), width);
                    shapeCounter[2]++;
                    return newSquare;

                case Shapes.Sphere:

                    Sphere newSphere = new(Center, width);
                    shapeCounter[3]++;
                    return newSphere;


                case Shapes.Cuboid:

                    Cuboid newCuboid = new(Center, new Vector3(width, height, depth));
                    shapeCounter[4]++;
                    return newCuboid;

                case Shapes.Cube:

                    Cuboid newCube = new(Center, width);
                    shapeCounter[5]++;
                    return newCube;

                case Shapes.Triangle:

                    Vector2 P1 = Shape.GetTrianglePoint();
                    Vector2 P2 = Shape.GetTrianglePoint();
                    Triangle newTriangle = new(P1, P2, Center);
                    shapeCounter[6]++;
                    return newTriangle;


                default: throw new ArgumentOutOfRangeException();


            }

        }


        private static Vector2 GetTrianglePoint()
        {
            return new((float)Random.Shared.NextDouble() * new Random().Next(0, 100), (float)Random.Shared.NextDouble() * new Random().Next(0, 100));
        }
        public enum Shapes
        {
            Circle,
            Rectangle,
            Square,
            Sphere,
            Cuboid,
            Cube,
            Triangle,
        }
    }
}