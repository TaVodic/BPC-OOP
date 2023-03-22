// See https://aka.ms/new-console-template for more information
using CV07;


int[] numbers =
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
};

string[] words =
{
    "apple",
    "mango",
    "bannana"
};

Circle[] circles =
{
    new Circle(5.2),
    new Circle(5.2),
};

Rectangle[] rects =
{
    new Rectangle(6.3, 3),
    new Rectangle(8.3, 3),
    new Rectangle(6.3, 8)
};

Object2D[] obj =
{
    new Circle(4),
    new Rectangle(5, 3),
    new Ellipse(5, 4)
};


Console.WriteLine(Extremes.Max(obj));
Console.WriteLine(Extremes.Min(rects));
Console.WriteLine(Extremes.Max(circles));

// Define the query expression.
IEnumerable<int> intreval =
    from inter in numbers
    where inter > 4 && inter < 8
    select inter;

// Execute the query.
foreach (int i in intreval)
{
    Console.Write(i + " ");
}
