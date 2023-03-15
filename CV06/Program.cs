// See https://aka.ms/new-console-template for more information
using CV06;

List<GrObject> objects = new List<GrObject>();

objects.Add(new Circle(2.5));
objects.Add(new Rectangle(5, 3));
objects.Add(new Ellipse(4, 2));
objects.Add(new Trinagle(7, 3));
objects.Add(new RectangCuboid(2.5, 5, 2));
objects.Add(new Cylinder(2.5, 5));
objects.Add(new Sphere(2.5));
objects.Add(new Piramid(7, 6));

double Area = 0;
double Surface = 0;
double Volume = 0;

foreach (GrObject obj in objects)
{
    obj.Draw();
    if (obj is Object2D object2)
    {
        Area += object2.CalcSurface();
    }
    if (obj is Object3D object3)
    {
        Surface += object3.CalcSurface();
        Volume += object3.CalcVolume();
    }
}

Console.WriteLine($"Total area: {Area}");
Console.WriteLine($"Total surface: {Surface}");
Console.WriteLine($"Total Volume: {Volume}");
Console.WriteLine($"Total Volume: {Volume}");