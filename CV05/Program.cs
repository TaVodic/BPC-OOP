// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

using CV05;

Osobni ford = new Osobni(Auto.FuelType.diesel, 50, 5);
Nakladni V3S = new Nakladni(Auto.FuelType.diesel, 500, 20);

V3S.fillTank(Auto.FuelType.diesel, 10);
V3S.CurCargo = 18;
Console.WriteLine(V3S);

ford.CurPassengers = 3;
try
{
    ford.fillTank(Auto.FuelType.gasoline, 20);
}
catch (Exception ex)
{
    Console.WriteLine("Chybi4ka: " + ex.Message);
}

Console.WriteLine(ford);


ford.createPreset(1, 2.5);
ford.setPreset(1);
Console.WriteLine(ford);

