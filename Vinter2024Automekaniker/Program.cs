// See https://aka.ms/new-console-template for more information
using Vinter2024Automekaniker;

Console.WriteLine("----- Sprint 1 ------");
Console.WriteLine("** Opgave A ***");
Car c1 = new Car("AV34545", 2013, "Skoda", "Octavia", 200000);
Car c2 = new Car("TV34545", 2015, "Mercedes", "C-klasse Sedan", 400000);
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine();

Console.WriteLine("** Opgave E ***");
CarCatalog catalog = new CarCatalog("John Sharp", 123133); 
catalog.AddCar(c1);
catalog.AddCar(c2);
Console.WriteLine("CarCatalog efter der er tilføjet 2 Car objekter");
Console.WriteLine(catalog.ToString());

Console.WriteLine("----- Sprint 2 ------");
Console.WriteLine("** Opgave H ***");
AutoRepair repair1 = new AutoRepair("Bremseklodser udskiftet", 7050.5);
AutoRepair repair2 = new AutoRepair("Benzinpumpe skiftet", 2025.5);
AutoRepair repair3 = new AutoRepair("Højre forhjul skiftet", 705);

Console.WriteLine(repair1);
Console.WriteLine(repair2);
Console.WriteLine(repair3);

Console.WriteLine("** Opgave I ***");
c1.AddRepair(repair1);
c1.AddRepair(repair2);
c2.AddRepair(repair3);
Console.WriteLine();
Console.WriteLine("Udskrift af et Car objekt med tilknyttet AutoRepair");
Console.WriteLine(c1.ToString());
Console.WriteLine("CarCatalog efter der er tilføjet reperationer til de to Car objekter");
Console.WriteLine(catalog.ToString());

Console.WriteLine("** Opgave J ***");
Car c3 = new Car("FT23455", 2020, "Ford", "Fuga", 25000);
AutoRepair repair4 = new AutoRepair("Motor skiftet", 27050);
c3.AddRepair(repair4);
catalog.AddCar(c3);

Console.WriteLine("** Opgave K ***");
AutoRepair repair5 = new AutoRepair("Tændrør skiftet", 1050);
catalog.AddRepairToCar("AV34545", repair5);
Console.WriteLine("Test af AddRepairToCar i CarCatalog");
Console.WriteLine(catalog.ToString());
Console.WriteLine();

Console.WriteLine("----- Sprint 3 ------");
Console.WriteLine("** Opgave L ***");
double totalCost = c1.TotalAutoRepairCost();
Console.WriteLine($"Total omkostning for bilen med regnr {c1.Regnr} er {totalCost} kr.");

Console.WriteLine("** Opgave M ***");
try
{
    Car c4 = new Car("12345678", 2022, "Volgwagen", "ID4", 15000);
}
catch(ArgumentException aex)
{
    Console.WriteLine(aex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Generel fejl " + ex.Message);
}

Console.ReadLine();
