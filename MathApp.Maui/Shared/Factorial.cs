using System.Numerics;

namespace MathApp.Maui.Shared;

class Factorial
{
    public static string CalculateFactorial(int inputNumber)
    {
        BigInteger result = 1;

        for (int i = 1; i <= inputNumber; i++)
        {
            result *= i;
        }

        string resultAsString = result.ToString();
        return resultAsString;
    }
}
