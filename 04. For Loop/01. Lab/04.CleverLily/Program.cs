//Input
int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

//Calculations
int toysCount = 0;
int money = 0;
int moneyIntake = 0;

for (int currentAge = 1; currentAge <= age; currentAge++)
{
    if (currentAge % 2 == 1)
    {
        toysCount++;
    }
    else
    {
        //money += (currentAge / 2) * 10;
        moneyIntake += 10;
        money += moneyIntake;

        //Brother takes 1 lv.
        money -= 1;
    }
}

int toyMoney = toysCount * toyPrice;
money += toyMoney;

//Output
if (money >= washingMachinePrice)
{
    double remainingMoney = money - washingMachinePrice;
    Console.WriteLine($"Yes! {remainingMoney:f2}");
}
else
{
    double notEnoughMoney = washingMachinePrice - money;
    Console.WriteLine($"No! {notEnoughMoney:f2}");
}