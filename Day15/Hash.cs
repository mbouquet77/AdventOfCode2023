

using System.Text;
using System.Linq;

namespace AOC2023Main.Day15
{
    public static class Hash
    {
        public static int GetHashResultSum(string lines)
        {
            var sum = 0;
            var array = lines.Split(',');
            foreach (var line in array)
            {
                sum += GetHastResult(line);
            }
            return sum;
        }

        public static int GetHastResult(string line)
        {
            var currentValue = 0;
            foreach (var asciiValue in from char c in line
                                       let asciiValue = (int)c
                                       select asciiValue)
            {
                currentValue += asciiValue;
                currentValue *= 17;
                currentValue %= 256;
            }

            return currentValue;
        }
    }
}
