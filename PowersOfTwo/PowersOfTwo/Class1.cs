using System.Linq;
using System.Numerics;

namespace PowersOfTwo
{
    public class Solution
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            return Enumerable.Range(0, n + 1).Select(x => BigInteger.Pow(2, x)).ToArray();
        }
    }
}
