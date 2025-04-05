//Input
int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

//Calculations
int combinationsCount = 0;
bool found = false;

for (int i = startNum; i <= endNum; i++)
{
    for (int j = startNum; j <= endNum; j++)
    {
        combinationsCount++;
        if (i + j == magicNum)
        {
            //Output
            found = true;
            Console.WriteLine($"Combination N:{combinationsCount} ({i} + {j} = {magicNum})");
            break;
        }

    }
    if (found)
    {
        break;
    }
}

//Output
if (!found)
{
    Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNum}");
}
