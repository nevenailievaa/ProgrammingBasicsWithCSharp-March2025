//Input
int daysCount = int.Parse(Console.ReadLine());
double allFood = double.Parse(Console.ReadLine());

//Calculations
double sumDogFood = 0;
double sumCatFood = 0;
double sumBiscuits = 0;

for (int day = 1; day <= daysCount; day++)
{
    int dogFoodEaten = int.Parse(Console.ReadLine());
    int catFoodEaten = int.Parse(Console.ReadLine());

    sumDogFood += dogFoodEaten;
    sumCatFood += catFoodEaten;

    if (day % 3 == 0)
    {
        sumBiscuits += (dogFoodEaten + catFoodEaten) * 0.10;
    }
}

double totalFoodEaten = sumDogFood + sumCatFood;
double totalFoodEatenPercent = totalFoodEaten / allFood * 100;
double dogFoodEatenPercent = sumDogFood / totalFoodEaten * 100;
double catFoodEatenPercent = sumCatFood / totalFoodEaten * 100;

//Output
Console.WriteLine($"Total eaten biscuits: {Math.Round(sumBiscuits)}gr.");
Console.WriteLine($"{totalFoodEatenPercent:f2}% of the food has been eaten.");
Console.WriteLine($"{dogFoodEatenPercent:f2}% eaten from the dog.");
Console.WriteLine($"{catFoodEatenPercent:f2}% eaten from the cat.");