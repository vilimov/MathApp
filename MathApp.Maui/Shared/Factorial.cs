using MathApp.Maui.Exceptions;
using MathApp.Maui.Exceptions.ExceptionMessages;
using System.Numerics;

namespace MathApp.Maui.Shared;

class Factorial
{
    public BigInteger CalculateFactorial(string inputNumber)
    {
        BigInteger factorial = BigInteger.Zero;
        int input = 0;

        if (!int.TryParse(inputNumber, out input)) 
        {
            throw new InvalidInputTypeException(ExceptionMessages.invalidInput);
        }
        return factorial;
    }
}
