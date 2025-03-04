
// Input
int neededNylon = int.Parse(Console.ReadLine());
int neededPaint = int.Parse(Console.ReadLine());
int neededThinner = int.Parse(Console.ReadLine());
int workingHours = int.Parse(Console.ReadLine());

// Calculations
//•	Предпазен найлон - 1.50 лв. за кв. метър
//•	Боя - 14.50 лв. за литър
//•	Разредител за боя - 5.00 лв. за литър
// и 0.40 лв. за торбички

double finalPriceForNylon = (neededNylon + 2) * 1.50;
double finalPriceForPaint = (neededPaint + (neededPaint * 0.10)) * 14.50;
double finalPriceForThinner = neededThinner * 5;

double priceForMaterials = finalPriceForNylon + finalPriceForPaint + finalPriceForThinner + 0.40;

double priceForOneHourWork = priceForMaterials * 30 / 100;
double finalPriceForWork = workingHours * priceForOneHourWork;

double finalPrice = priceForMaterials + finalPriceForWork;

// Output
Console.WriteLine(finalPrice);


