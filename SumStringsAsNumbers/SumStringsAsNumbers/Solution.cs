using System;
using System.Numerics;

namespace SumStringsAsNumbers
{
    public class Solution
    {
        public static string SumStrings(string a, string b)
        {
            BigInteger parsedA = 0;
            BigInteger parsedB = 0;

            BigInteger.TryParse(a, out parsedA);
            BigInteger.TryParse(b, out parsedB);

            return (parsedA + parsedB).ToString();
        }
    }
}
