//Input
int number = int.Parse(Console.ReadLine());

//Calculations
bool isValid = number >= 100 && number <= 200 || number == 0;

//Output
if (!isValid)
{
    Console.WriteLine("invalid");
}