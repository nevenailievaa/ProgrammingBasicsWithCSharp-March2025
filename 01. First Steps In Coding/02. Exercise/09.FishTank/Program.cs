// Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

// Calculations
int allVolume = length * width * height;
double allVolumeInliters = allVolume / 1000.0;  // или умножаваме по 0.001

double restVolumeInLiters = allVolumeInliters * (1 - percent / 100);

// Output
Console.WriteLine(restVolumeInLiters);
