// Input
int taxPerYear = int.Parse(Console.ReadLine());

// Calculations
double shoesPrice = taxPerYear - (taxPerYear * 0.4);
double suitePrice = shoesPrice - (shoesPrice * 0.2);
double ballPrice = suitePrice / 4;
double accessoriesPrice = ballPrice / 5;

double totalSum = taxPerYear + shoesPrice + suitePrice + ballPrice + accessoriesPrice;

// Output
Console.WriteLine(totalSum);
