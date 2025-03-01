//Input
int dogFoodCansCount = int.Parse(Console.ReadLine());
int catFoodCansCount = int.Parse(Console.ReadLine());

//Calculations
double allFoodPrice = dogFoodCansCount * 2.50 + catFoodCansCount * 4;

//Output
Console.WriteLine($"{allFoodPrice} lv.");