
using CV03;

double[,] M = new double[2, 2] { { 5, 9 }, 
                                 { 7, 6 } };

double[,] L = new double[2, 2] { { 5, 9 }, 
                                 { 7, 6 } };

double[,] S = new double[4, 4] { { 5, 9, 2, 1 },
                                 { 7, 6, 3, 1 },
                                 { 4, 1, 3, 8 },
                                 { 4, 1, 3, 1 }};


Matrix MM = new Matrix(M);
Matrix LL = new Matrix(L);
Matrix SS = new Matrix(S);

try
{
    Console.WriteLine(MM + SS);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(MM - LL);
Console.WriteLine(MM * LL);
Console.WriteLine(MM == LL);
Console.WriteLine(MM != LL);
Console.WriteLine(-MM);

Console.WriteLine(Matrix.determinat(SS));