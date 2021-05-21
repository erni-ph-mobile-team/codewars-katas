using System.Collections.Generic;
using System.Linq;

namespace CountingDuplicates
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            var strLower = str.ToLower();
            var dict = new Dictionary<string, int>();

            foreach (var letter in strLower)
            {
                dict[letter.ToString()] = strLower.Count(s => string.Equals(s, letter));
            }

            return dict.Values.Where(v => v > 1).Count();
        }
    }
}
