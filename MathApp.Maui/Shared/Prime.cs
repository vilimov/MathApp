using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Maui.Shared;

class Prime
{
    public static bool IsPrime(int input) 
    {
        for (int i = 2; i <= Math.Sqrt(input); i++) 
        {
            if (input % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
