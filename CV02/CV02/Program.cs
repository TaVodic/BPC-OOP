using CV02;

TestComplex.Test(new Complex(3.0, 4.0) + new Complex(2.0, 1.0), new Complex(5.0, 5.0), "+");
TestComplex.Test(new Complex(3.0, 4.0) - new Complex(2.0, 1.0), new Complex(5.0, 5.0), "-");
TestComplex.Test(new Complex(1.0, 4.0) * new Complex(2.0, 1.0), new Complex(-2.0, 9.0), "*");
TestComplex.Test(new Complex(3.0, 4.0) / new Complex(2.0, 1.0), new Complex(5.0, 5.0), "/");
TestComplex.Test(-new Complex(1.0, 2.5), new Complex(-1.0, -2.5), "-");
TestComplex.Test(new Complex(1.0, 2.5).Conjugate(), new Complex(1.0, -2.5), "conjugate");

Console.WriteLine("Equals: {0}", new Complex(3.0, 4.0) == new Complex(3.0, 4.0));
Console.WriteLine("Not equals: {0}", new Complex(3.0, 4.0) != new Complex(3.0, 4.0));
Console.WriteLine("Argument: {0}", new Complex(3.0, 4.0).Argument());
Console.WriteLine("Module: {0}", new Complex(3.0, 4.0).Module());
