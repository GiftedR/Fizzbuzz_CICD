using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Sample
{
    public static class FizzBuzz_Library
    {
        public static string FizzBuzz(int num)
        {
            string result = "";
            if (Mod(num, 3) == 0)
            {
                result += "Fizz";
            }
            if (Mod(num, 5) == 0)
            {
                result += "Buzz";
            }
            if (result.Length == 0)
            {
                result = num.ToString();
            }

            return result;
        }

        public static int Mod(int x, int y)
        {
            return x - (x / y) * y; // This is post refactored state
        }
    }
}
