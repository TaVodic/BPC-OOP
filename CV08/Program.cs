// See https://aka.ms/new-console-template for more information
using CV08;

Console.WriteLine("Hello, World!");

YearTemp year1 = new YearTemp(new List<double> { -2.5, 3.5, 12, -0.5, 25, 23.6, 15, 28 }, 2020);
YearTemp year2 = new YearTemp(new List<double> { -2.5, 3.5, 12, -0.5, -26, -23.7, 15, 22 }, 2021);
YearTemp year3 = new YearTemp(new List<double> { -2.5, -3.5, 12, -0.5, -25, 23.8, -14, 28 }, 2022);
YearTemp year4 = new YearTemp(new List<double> { -2.5, 3.5, -12, -0.5, 25, -23.7, -15, 28 }, 2023);

TempArch arch = new TempArch(new List<YearTemp> {year1, year2, year3, year4 });

//arch.PrintAvgMonth();
arch.Save(@".\File1.txt");
arch.Load(@".\File1.txt");
arch.PrintTemp();
arch.PrintAvgTemp();
arch.Calibration(-0.1);
arch.Save(@".\File1.txt");