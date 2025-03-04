// Input
double deposit = double.Parse(Console.ReadLine());
int period = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

// Calculations

double yearIncome = deposit * (percent / 100);
double monthIncome = yearIncome / 12;

double finalSum = deposit + monthIncome * period;

// Output
Console.WriteLine(finalSum);
