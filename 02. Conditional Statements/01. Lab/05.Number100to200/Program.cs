//Input
int number = int.Parse(Console.ReadLine());

//Checks
if (number > 200)
{
    Console.WriteLine("Greater than 200");
}
else if (number >= 100)
{
    Console.WriteLine("Between 100 and 200");
}
else
{
    Console.WriteLine("Less than 100");
}
