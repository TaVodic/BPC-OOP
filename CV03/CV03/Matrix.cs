using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CV03
{
    internal class Matrix
    {
        public double[,] Data; //atribut
        //public double[,] myMatrix { get; set; } //vlastnost

        public int Rows => Data.GetLength(0);
        public int Columns => Data.GetLength(1);


        public Matrix(double[,] matrix)
        {
            Data = matrix;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Invalid matrix sizes");

            var result = new double[a.Rows, a.Columns];

            for (var row = 0; row < a.Rows; row++)
            {
                for (var col = 0; col < a.Columns; col++)
                {
                    result[row, col] = a.Data[row, col] + b.Data[row, col];
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Invalid matrix sizes");

            var result = new double[a.Rows, a.Columns];

            for (var row = 0; row < a.Rows; row++)
            {
                for (var col = 0; col < a.Columns; col++)
                {
                    result[row, col] = a.Data[row, col] - b.Data[row, col];
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Rows != b.Columns || a.Columns != b.Rows)
                throw new ArgumentException("Invalid matrix sizes");

            var result = new double[a.Rows, a.Columns];
            var temp = 0.00;
            for (var row = 0; row < a.Rows; row++)
            {
                for (var col = 0; col < a.Columns; col++)
                {
                    temp = 0;
                    for (var k = 0; k < a.Columns; k++)
                    {
                        temp += a.Data[row, k] * b.Data[k, col];
                    }
                    result[row, col] = temp;
                }
            }

            return new Matrix(result);
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Invalid matrix sizes");

            var result = new double[a.Rows, a.Columns];

            for (var row = 0; row < a.Rows; row++)
            {
                for (var col = 0; col < a.Columns; col++)
                {
                    if (a.Data[row, col] != b.Data[row, col])
                        return false;
                }
            }
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);

        }

        public static Matrix operator -(Matrix a)
        {
            var result = new double[a.Rows, a.Columns];

            for (var row = 0; row < a.Rows; row++)
            {
                for (var col = 0; col < a.Columns; col++)
                {
                    result[row, col] = -a.Data[row, col];
                }
            }

            return new Matrix(result);
        }

        public static double determinat(Matrix a)
        {
            if (a.Rows != a.Columns)
                throw new ArgumentException("Must be aquare matrix!");

            var n = a.Columns;
            int index = 0;
            double det = 1;
            double num1, num2;
            double total = 1;


            double[] temp = new double[n + 1];

            for (int i = 0; i < n; i++)
            {
                index = i;

                while (index < n && a.Data[index, i] == 0)
                {
                    index++;
                }
                if (index == n)
                {

                    continue;
                }
                if (index != i)
                {

                    for (int j = 0; j < n; j++)
                    {
                        swap(a, index, j, i, j);
                    }

                    det = (double)(det * Math.Pow(-1, index - i));
                }

                for (int j = 0; j < n; j++)
                {
                    temp[j] = a.Data[i, j];
                }


                for (int j = i + 1; j < n; j++)
                {
                    num1 = temp[i];
                    num2 = a.Data[j, i];

                    for (int k = 0; k < n; k++)
                    {

                        a.Data[j, k] = (num1 * a.Data[j, k]) - (num2 * temp[k]);
                    }
                    total = total * num1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                det = det * a.Data[i, i];
            }
            return (det / total);
        }

        private static double[,] swap(Matrix arr, int i1, int j1, int i2, int j2)
        {
            double temp = arr.Data[i1, j1];
            arr.Data[i1, j1] = arr.Data[i2, j2];
            arr.Data[i2, j2] = temp;
            return arr.Data;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int row = 0; row < Data.GetLength(0); row++)
            {
                for (int col = 0; col < Data.GetLength(1); col++)
                {
                    output.AppendFormat("{0:F2}\t", Data[row, col]);
                }
                output.Append(Environment.NewLine);
            }
            return output.ToString();
        }
    }
}
