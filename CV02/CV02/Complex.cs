using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV02
{
    internal class Complex
    {
        public double Real;
        public double Imaginary;

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        
        public static Complex operator -(Complex a)
        {
            return new Complex(-a.Real, -a.Imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.Real*b.Real+a.Imaginary*b.Imaginary)/(Math.Pow(b.Real, 2)+ Math.Pow(b.Imaginary, 0)), (a.Imaginary * b.Real - a.Real * b.Imaginary) / (Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 0)));
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            if (Imaginary < 0)
            {
                return string.Format("{0}{1}j", Real, Imaginary);
            }
            else
            {
                return string.Format("{0}+{1}j", Real, Imaginary);
            }
        }

        public Complex Conjugate()
        {
            return new Complex(Real, -Imaginary);
        }

        public double Module()
        {
            return Math.Sqrt(Real * Real + Math.Pow(Imaginary, 2));
        }

        public double Argument()
        {
            return Math.Atan(Real / Imaginary);
        }
    }
}
