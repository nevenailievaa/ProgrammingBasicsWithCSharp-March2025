//Input
string figure = Console.ReadLine();

//Calculations
double area = 0;

if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;
}
else if (figure == "rectangle")
{
    double length = double.Parse(Console.ReadLine());
    double width = double.Parse(Console.ReadLine());

    area = length * width;
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());

    area = Math.PI * radius * radius;
}
else if (figure == "triangle")
{
    double side = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());

    area = side * height / 2;
}

//Output
Console.WriteLine($"{area:F3}");
