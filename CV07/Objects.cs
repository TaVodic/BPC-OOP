using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Circle : Object2D
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override string ToString()
        {
           return $"Circle, Radius = {radius}, Surface = {Area()}";
        }

        public override double Area()
        {
            return 2*Math.PI*radius;
        }
    }

    internal class Rectangle : Object2D
    {
        private double lenght;
        private double width;

        public Rectangle(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public override string ToString()
        {
            return $"Rectangle, Length = {lenght}, Width = {width}, Surface = {Area()}";
        }

        public override double Area()
        {
            return lenght*width;
        }

    }

    internal class Ellipse : Object2D
    {
        private double a;
        private double b;

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return $"Ellipse, A = {a}, B = {b}, Surface = {Area()}";
        }
        public override double Area()
        {
            return a * b * Math.PI;
        }

    }
    /*
    internal class Trinagle : Object2D
    {
        private double height;
        private double _base;

        public Trinagle(double height, double @base)
        {
            this.height = height;
            _base = @base;
        }

        public override void Draw()
        {
            Console.WriteLine($"Trinagle, Height = {height}, Base = {_base}, Surface = {CalcSurface()}");
        }
        public override double CalcSurface()
        {
            return height*_base/2;
        }
    }
    internal class RectangCuboid : Object3D
    {
        private double width;
        private double height;
        private double length;

        public RectangCuboid(double width, double height, double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public override void Draw()
        {
            Console.WriteLine($"RectangCuboid, Height = {height}, width = {width}, length = {length}, Surface = {CalcSurface()}, Volume = {CalcVolume()}");
        }
        public override double CalcSurface()
        {
            return width*length*2 + length*height*2 + width*height*2;
        }

        public override double CalcVolume()
        {
            return width * height * length;
        }

    }
    internal class Cylinder : Object3D
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Cylinder, Height = {height}, radius = {radius}, Surface = {CalcSurface()}, Volume = {CalcVolume()}");
        }
        public override double CalcSurface()
        {
            return 2*Math.PI*radius*(radius+height);
        }

        public override double CalcVolume()
        {
            return Math.PI*Math.Pow(radius, 2)*height;
        }
    }
    internal class Sphere : Object3D
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Sphere, radius = {radius}, Surface = {CalcSurface()}, Volume = {CalcVolume()}");
        }
        public override double CalcSurface()
        {
            return 4*Math.PI*Math.Sqrt(radius);
        }

        public override double CalcVolume()
        {
            return 4/3*Math.PI*Math.Pow(radius, 3);
        }
    }

    internal class Piramid : Object3D
    {
        public double a;
        public double height;

        public Piramid(double a, double height)
        {
            this.a = a;
            this.height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Piramid, height = {height}, a = {a}, Surface = {CalcSurface()}, Volume = {CalcVolume()}");
        }
        public override double CalcSurface()
        {
            return a*(a+Math.Sqrt(4*Math.Pow(height, 2) + Math.Pow(height, 2)));
        }

        public override double CalcVolume()
        {
            return 1/3*Math.Pow(a, 2)*height;
        }
    }*/
}

