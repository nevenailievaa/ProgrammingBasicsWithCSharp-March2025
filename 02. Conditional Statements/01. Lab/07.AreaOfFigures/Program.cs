//Input
string figure = Console.ReadLine();

//Checks
double area = 0;

if (figure == "square" )
{
    double sideLength = double.Parse(Console.ReadLine());
    area = sideLength * sideLength;
}
else if (figure == "rectangle")
{
    double length = double.Parse(Console.ReadLine());
    double width = double.Parse(Console.ReadLine());

    area = length * width;
}
else if (figure == "circle")
{
    double raius = double.Parse(Console.ReadLine());

    area = Math.PI * (raius * raius);
}
else if (figure == "triangle")
{
    double sideLength = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());

    area = sideLength * height / 2;
}

//Output
Console.WriteLine($"{area:f2}");