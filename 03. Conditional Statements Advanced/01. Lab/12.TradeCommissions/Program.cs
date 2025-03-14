//Input
string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());
double comission = 0;

//Calculations
if (city == "Sofia")
{
    if (sales > 10000)
        comission = 0.12;
    else if (sales > 1000)
        comission = 0.08;
    else if (sales > 500)
        comission = 0.07;
    else if (sales >= 0)
        comission = 0.05;
    else
        Console.WriteLine("error");
}
else if (city == "Varna")
{
    if (sales > 10000)
        comission = 0.13;
    else if (sales > 1000)
        comission = 0.1;
    else if (sales > 500)
        comission = 0.075;
    else if (sales >= 0)
        comission = 0.045;
}
else if (city == "Plovdiv")
{
    if (sales > 10000)
        comission = 0.145;
    else if (sales > 1000)
        comission = 0.12;
    else if (sales > 500)
        comission = 0.08;
    else if (sales >= 0)
        comission = 0.055;
}

//Output
if (comission == 0)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine($"{sales * comission:f2}");
}