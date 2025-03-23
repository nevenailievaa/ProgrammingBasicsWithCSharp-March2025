//Input
int n = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;
int maxNumber = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum = sum + currentNumber; //sum += currentNumber;

    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber;
    }
}

sum = sum - maxNumber; //sum -= maxNumber;

//Output
if (sum == maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    int difference = Math.Abs(sum - maxNumber);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}