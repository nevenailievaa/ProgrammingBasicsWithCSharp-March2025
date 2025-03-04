// Input
int countPackagesOfPens = int.Parse(Console.ReadLine());
int countPackagesOfMarkers = int.Parse(Console.ReadLine());
int fluidInLitres = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

// Calculations
//•	Пакет химикали - 5.80 лв. 
//•	Пакет маркери - 7.20 лв. 
//•	Препарат - 1.20 лв (за литър)

double finalPriceForPens = countPackagesOfPens * 5.80;
double finalPriceForMarkers = countPackagesOfMarkers * 7.20;
double finalPriceForFluid = fluidInLitres * 1.20;

double priceForAllMaterials = finalPriceForPens + finalPriceForMarkers + finalPriceForFluid;

double discount = priceForAllMaterials * percentDiscount / 100;

double finalPrice = priceForAllMaterials - discount;

// Output
Console.WriteLine(finalPrice);