// Input
int countOfPages = int.Parse(Console.ReadLine());
int readPagesPerHour = int.Parse(Console.ReadLine());
int countOfDays = int.Parse(Console.ReadLine());

// Calculations
int allHoursForReading = countOfPages / readPagesPerHour;
int hoursReadPerDay = allHoursForReading / countOfDays;

// Output
Console.WriteLine(hoursReadPerDay);

