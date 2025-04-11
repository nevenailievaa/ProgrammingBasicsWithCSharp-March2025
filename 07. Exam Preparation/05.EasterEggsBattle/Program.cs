//Input
int firstPlayerEggs = int.Parse(Console.ReadLine());
int secondPlayerEggs = int.Parse(Console.ReadLine());
string winner = string.Empty;

//Calculations
while ((winner = Console.ReadLine()) != "End" && firstPlayerEggs > 0 && secondPlayerEggs > 0)
{
    if (winner == "one")
        secondPlayerEggs--;
    else if (winner == "two")
        firstPlayerEggs--;
}

//Output
if (firstPlayerEggs == 0)
{
    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
}
else if (secondPlayerEggs == 0)
{
    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
}
else
{
    Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
    Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
}