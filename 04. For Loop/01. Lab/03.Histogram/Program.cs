﻿//Input
int allNumbersCount = int.Parse(Console.ReadLine());

//Calculations
int p1NumbersCount = 0;
int p2NumbersCount = 0;
int p3NumbersCount = 0;
int p4NumbersCount = 0;
int p5NumbersCount = 0;

for (int i = 1; i <= allNumbersCount; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber < 200)
    {
        p1NumbersCount++;
    }
    else if (currentNumber <= 399)
    {
        p2NumbersCount++;
    }
    else if (currentNumber <= 599)
    {
        p3NumbersCount++;
    }
    else if (currentNumber <= 799)
    {
        p4NumbersCount++;
    }
    else if (currentNumber >= 800)
    {
        p5NumbersCount++;
    }
}

double p1NumbersPercent = (double)p1NumbersCount / allNumbersCount * 100;
double p2NumbersPercent = (double)p2NumbersCount / allNumbersCount * 100;
double p3NumbersPercent = (double)p3NumbersCount / allNumbersCount * 100;
double p4NumbersPercent = (double)p4NumbersCount / allNumbersCount * 100;
double p5NumbersPercent = (double)p5NumbersCount / allNumbersCount * 100;

//Output
Console.WriteLine($"{p1NumbersPercent:f2}%");
Console.WriteLine($"{p2NumbersPercent:f2}%");
Console.WriteLine($"{p3NumbersPercent:f2}%");
Console.WriteLine($"{p4NumbersPercent:f2}%");
Console.WriteLine($"{p5NumbersPercent:f2}%");