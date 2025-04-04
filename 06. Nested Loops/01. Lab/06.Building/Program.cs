//Input
int floorsCount = int.Parse(Console.ReadLine());
int roomsCount = int.Parse(Console.ReadLine());

//Output
for (int f = floorsCount; f >= 1; f--)
{
    for (int r = 0; r < roomsCount; r++)
    {
        if (f == floorsCount)
        {
            Console.Write($"L{f}{r} ");
        }
        else if (f % 2 == 1)
        {
            Console.Write($"A{f}{r} ");
        }
        else if (f % 2 == 0)
        {
            Console.Write($"O{f}{r} ");
        }
    }
    Console.WriteLine();
}