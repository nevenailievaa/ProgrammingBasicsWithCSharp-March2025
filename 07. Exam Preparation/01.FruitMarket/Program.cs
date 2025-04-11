double strawberriesPrice = double.Parse(Console.ReadLine());
double bananas = double.Parse(Console.ReadLine());
double oranges = double.Parse(Console.ReadLine());
double raspberries = double.Parse(Console.ReadLine());
double strawberries = double.Parse(Console.ReadLine());

double raspberriesPrice = strawberriesPrice / 2;
double orangesPrice = raspberriesPrice - (raspberriesPrice * 0.4);
double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.8);

double totalPrice = strawberriesPrice * strawberries + bananasPrice * bananas + orangesPrice * oranges + raspberriesPrice * raspberries;

Console.WriteLine(String.Format($"{totalPrice:f2}"));