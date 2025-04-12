//Input
double movieBudget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int daysCount = int.Parse(Console.ReadLine());

//Calculations
double sum = 0;

if (destination == "Dubai")
{
    if (season == "Winter")
    {
        sum = 45000 * daysCount;
    }
    else if (season == "Summer")
    {
        sum = 40000 * daysCount;
    }

    //Additional discount
    sum = sum * 0.70;
}
else if (destination == "Sofia")
{
    if (season == "Winter")
    {
        sum = 17000 * daysCount;
    }
    else if (season == "Summer")
    {
        sum = 12500 * daysCount;
    }

    //Additional Pay
    sum = sum * 1.25;
}
else if (destination == "London")
{
    if (season == "Winter")
    {
        sum = 24000 * daysCount;
    }
    else if (season == "Summer")
    {
        sum = 20250 * daysCount;
    }
}

//Output
if (movieBudget >= sum)
{
    Console.WriteLine($"The budget for the movie is enough! We have {movieBudget - sum:f2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {sum - movieBudget:f2} leva more!");
}
