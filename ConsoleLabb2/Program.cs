// See https://aka.ms/new-console-template for more information
using ClassLibrary1;
using System.Globalization;
using System.Numerics;



Shape[] Shapes = new Shape[20];
float avgArea = 0;
float triangleCircumference = 0;
float biggestVolume = 0;
string biggestVolumeShape = String.Empty;
int mostCommonShape = 0;
string mostCommonShapeName = string.Empty;
string twoMostCommonShapeName = string.Empty;
for (int i = 0; i < 20; i++)
{
    Shapes[i] = Shape.GenerateShape();
    Console.WriteLine(Shapes[i]);
    avgArea += Shapes[i].Area;
    if (Shapes[i] is Triangle t)
    {
        triangleCircumference += t.circumference;
    }
    if (Shapes[i] is Shape3D s && s.volume > biggestVolume)
    {
        biggestVolume = s.volume;
        biggestVolumeShape = s.name;

    }

}
for (int x = 0; x < Shape.shapeCounter.Length ; x++)
{

    if (Shape.shapeCounter[x] > mostCommonShape)
    {
        mostCommonShape = Shape.shapeCounter[x];
        var tempname = (Shape.Shapes)x;
        mostCommonShapeName = tempname.ToString();
    }
    if (Shape.shapeCounter[x] == mostCommonShape)
    {
        var twoNamesTest = (Shape.Shapes)x;

        if (mostCommonShapeName != twoNamesTest.ToString())
        {
            twoMostCommonShapeName = twoNamesTest.ToString();
        }
        else
        {
            continue;
        }

    }
}
Console.WriteLine($"The average area of the shapes is " + avgArea / 20);
Console.WriteLine($"The sum of all triangles circumferences is {triangleCircumference}");
Console.WriteLine($"The 3D shape with the biggest volume is {biggestVolumeShape} and it's volume is {biggestVolume}");
Console.WriteLine($"The most common shape is {mostCommonShapeName} and it accours {mostCommonShape} times");

if (twoMostCommonShapeName != string.Empty)
{ Console.Write($"And {twoMostCommonShapeName} also occours that many times"); }

//Vector2 testVector = new Vector2(1f, 2f);

//Circle cirkel = new Circle(testVector, 1f);

//Console.WriteLine(cirkel.Center);
