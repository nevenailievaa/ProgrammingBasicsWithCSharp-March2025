//Input
string destination = Console.ReadLine();

//Calculations 
while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double savedMoney = 0;

    while (savedMoney < budget)
    {
        double currentMoneySave = double.Parse(Console.ReadLine());
        savedMoney += currentMoneySave;
    }

    //Output
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}