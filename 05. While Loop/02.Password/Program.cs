//Input
string username = Console.ReadLine();
string password = Console.ReadLine();

//Password Check
string inputPassword = Console.ReadLine();

while (inputPassword != password)
{
    inputPassword = Console.ReadLine();
}

//Output
Console.WriteLine($"Welcome {username}!");