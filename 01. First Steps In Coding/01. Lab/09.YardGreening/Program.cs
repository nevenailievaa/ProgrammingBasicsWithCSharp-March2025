//Input
double metersToGreen = double.Parse(Console.ReadLine());

//Calculations
double greeningPrice = metersToGreen * 7.61;
double discount = greeningPrice * 0.18;
double discountedPrice = greeningPrice - discount;

//Output
Console.WriteLine($"The final price is: {discountedPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");