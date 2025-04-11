//Input
double buget = double.Parse(Console.ReadLine());
int nightsCount = int.Parse(Console.ReadLine());
double nightPrice = double.Parse(Console.ReadLine());
int additionalCostsPercent = int.Parse(Console.ReadLine());

//Calculations
double additionalsCost = buget * additionalCostsPercent / 100;

if (nightsCount > 7)
{
    nightPrice *= 0.95;
}

double allPrice = nightsCount * nightPrice + additionalsCost;

//Output
if (allPrice > buget)
{
    Console.WriteLine($"{allPrice - buget:F2} leva needed.");
}
else
{
    Console.WriteLine($"Ivanovi will be left with {buget - allPrice:F2} leva after vacation.");
}