//Input
string studentName = Console.ReadLine();

//Calculations
int expelsCount = 0;
int passedYears = 0;
double gradesSum = 0;

while (expelsCount < 2 && passedYears < 12)
{
    double grade = double.Parse(Console.ReadLine());

    //Expelled
    if (grade < 4)
    {
        expelsCount++;
        continue;
    }
    //Passed
    else
    {
        gradesSum += grade;
        passedYears++;
    }
}

//Graduated Successfully
if (expelsCount < 2)
{
    double averageGrade = gradesSum / passedYears;
    Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
}
//Did Not Graduate
else
{
    Console.WriteLine($"{studentName} has been excluded at {passedYears + 1} grade");
}
