//Input
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

//Calculations
int numOneFirstDigit = int.Parse(num1[0].ToString());
int numOneSecondDigit = int.Parse(num1[1].ToString());
int numOneThirdDigit = int.Parse(num1[2].ToString());
int numOneFourthDigit = int.Parse(num1[3].ToString());

int numTwoFirstDigit = int.Parse(num2[0].ToString());
int numTwoSecondDigit = int.Parse(num2[1].ToString());
int numTwoThirdDigit = int.Parse(num2[2].ToString());
int numTwoFourthDigit = int.Parse(num2[3].ToString());

for (int i = numOneFirstDigit; i <= numTwoFirstDigit; i++)
{
    if (i % 2 != 0)
    {
        for (int j = numOneSecondDigit; j <= numTwoSecondDigit; j++)
        {
            if (j % 2 != 0)
            {
                for (int k = numOneThirdDigit; k <= numTwoThirdDigit; k++)
                {
                    if (k % 2 != 0)
                    {
                        for (int l = numOneFourthDigit; l <= numTwoFourthDigit; l++)
                        {
                            if (l % 2 != 0)
                            {
                                //Output
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}