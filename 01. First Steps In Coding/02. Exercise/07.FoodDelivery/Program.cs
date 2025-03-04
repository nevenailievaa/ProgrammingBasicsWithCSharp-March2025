//Prices
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double veganMenuPrice = 8.15;
double deliveryPrice = 2.50;

//Inputs
int numbOfChickenMenu = int.Parse(Console.ReadLine());
int numbOfFishMenu = int.Parse(Console.ReadLine());
int numbOfVeganMenu = int.Parse(Console.ReadLine());

//Calculations
double chickenMenuSum = numbOfChickenMenu * chickenMenuPrice;
double fishMenuSum = numbOfFishMenu * fishMenuPrice;
double veganMenuSum = numbOfVeganMenu * veganMenuPrice;

double totalMenuPrice = chickenMenuSum + fishMenuSum + veganMenuSum;

double desertPrice = totalMenuPrice * 0.2;

double finalPrice = totalMenuPrice + desertPrice + deliveryPrice;

//Outputs
Console.WriteLine(finalPrice);

