//Input
string architectName = Console.ReadLine();
int projectsCount = int.Parse(Console.ReadLine());

//Calculations
int hoursNeeded = projectsCount * 3;

//Output
Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {projectsCount} project/s.");